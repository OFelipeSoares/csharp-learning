using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas_de_Repeti__ao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i <5 ; i++)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é " + total);
            /*
            double valorInvestido = Convert.ToDouble(inputValor.Text);
            int tempoInvestido = Convert.ToInt32(InputTempo.Text);

            for (int i = 0; i < tempoInvestido; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            int i = 1; 
            
             while (i <= tempoInvestido) ;
            {
                valorInvestido = valorInvestido * 1.01;
                i++;
            }
            

            MessageBox.Show($"O valor investido ao final dos {InputTempo} meses é {valorInvestido}");
            */
        }
    }
}
