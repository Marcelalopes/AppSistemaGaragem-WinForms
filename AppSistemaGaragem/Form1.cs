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

        private void btEntrada_Click(object sender, EventArgs e)
        {
            listaEntrada.Add(new Veiculo(tbPlaca.Text, dtpHora.Value, dtpData.Value));
            Persistencia.gravarNoArquivoEntrada(listaEntrada);

            tbListaEntrada.AppendText(tbPlaca.Text + " - " + dtpHora.Value + " - " + dtpData.Value+Environment.NewLine);

            MessageBox.Show($"{tbPlaca.Text}\n{dtpHora.Value}\n{dtpData.Value}");
        }
    }
}
