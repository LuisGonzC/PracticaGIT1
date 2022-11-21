using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTelegrama_TextChanged(object sender, EventArgs e)
        {
            string textoTelegrama;
            string tipoTelegrama = "o";
            int numPalabras = 0;
            double coste = 0;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            //Telegrama urgente
            if (cdUrgente.Checked)
            {
                tipoTelegrama = "u";
            }

            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == "o")
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            if (tipoTelegrama == "u")
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = int.Parse(Interaction.InputBox("Numero: "));
        }
    }
}
