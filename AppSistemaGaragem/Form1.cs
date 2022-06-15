using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaGaragem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();

        private void popularTextBoxListaEntrada(List<Veiculo> lista)
        {
            tbListaEntrada.Text = "";
            foreach (Veiculo i in lista)
            {
                tbListaEntrada.AppendText(tbPlaca.Text + " - " + dtpHora.Value + " - " + dtpData.Value + Environment.NewLine);
            }
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            listaEntrada.Add(new Veiculo(tbPlaca.Text, dtpHora.Value, dtpData.Value));
            Persistencia.gravarNoArquivoEntrada(listaEntrada);

            popularTextBoxListaEntrada(listaEntrada);

            MessageBox.Show($"{tbPlaca.Text}\n{dtpHora.Value}\n{dtpData.Value}");
        }

        private void btSaida_Click(object sender, EventArgs e)
        {
            int indice;
            foreach (Veiculo i in listaEntrada)
            {
                if (i.Placa.Equals(tbPlaca.Text))
                {
                    indice = listaEntrada.IndexOf(i);

                    listaSaida.Add(i);
                    i.HoraSaida = DateTime.Now;
                    i.TempoPermanencia = i.HoraSaida.Subtract(i.HoraEntrada);
                    i.ValorCobrado = Math.Ceiling(i.TempoPermanencia.TotalMinutes/60)*5.00;

                    Persistencia.gravarNoArquivoSaida(listaSaida);
                    tbListaSaida.AppendText(tbPlaca.Text + " - " + (int)i.TempoPermanencia.TotalHours + " - " + i.ValorCobrado);

                    listaEntrada.RemoveAt(indice);
                    Persistencia.gravarNoArquivoEntrada(listaEntrada);
                    popularTextBoxListaEntrada(listaEntrada);

                    MessageBox.Show($"{tbPlaca.Text}\n{(int)i.TempoPermanencia.TotalHours} hora(s)\n{i.ValorCobrado} reais");
                    break;
                }
            }
        }
    }
}
