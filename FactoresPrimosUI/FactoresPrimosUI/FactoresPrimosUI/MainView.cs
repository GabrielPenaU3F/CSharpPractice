using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoresPrimosUI
{
    public partial class MainView : Form
    {

        const String tab = "  ";

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtBoxNumero.Text != "")
            {
                int numero = int.Parse(txtBoxNumero.Text);
                Factorizador factorizador = new Factorizador();
                List<int> factoresPrimos = factorizador.Factorizar(numero);
                this.imprimirFactoresEnLabel(factoresPrimos, factoresPrimosLbl);
            }
        }

        private void imprimirFactoresEnLabel(List<int> factoresPrimos, Label factoresPrimosLbl)
        {
            String factoresString = "";
            foreach (int factor in factoresPrimos)
            {
                factoresString += factor.ToString();
                factoresString += tab;
            }
            factoresPrimosLbl.Text = factoresString;
        }
    }
}
