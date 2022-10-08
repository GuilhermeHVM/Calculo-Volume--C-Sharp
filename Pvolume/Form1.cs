using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();

            txtRaio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;

            if(Double.TryParse(txtAltura.Text, out altura)&&
               Double.TryParse(txtRaio.Text, out raio))
            {
                if ((altura <= 0 ) ||(raio <= 0))
                {
                    MessageBox.Show("altura e raio devem ser maior que zero");
                    txtRaio.Focus();
                }
                else
                {
                    // volume = 3.14 * raio *raio * altura;
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = volume.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Valores invalidos");
                txtRaio.Focus();
            }
        }
    }
}
