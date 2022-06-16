using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaGaragem
{
    class Persistencia
    {
        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("VeiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada);
                escritor.Flush();
            }
            escritor.Close();
        }

        public static void lerDoArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("VeiculosEntrada.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], Convert.ToDateTime(vetorDados[1]), Convert.ToDateTime(vetorDados[2])));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("VeiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.HoraSaida + ";" + i.TempoPermanencia + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        public static void lerDoArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("VeiculosSaida.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1]), DateTime.Parse(vetorDados[2]), DateTime.Parse(vetorDados[3]), TimeSpan.Parse(vetorDados[4]), Convert.ToDouble(vetorDados[5])));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
    }
}
