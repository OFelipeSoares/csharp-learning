using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conta.cs
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = Convert.ToInt32(numeroConta);
            //c.titular = Convert.ToString(titularConta);
            c.saldo = Convert.ToDouble(saldoConta);
            bool deuCerto = c.Saca(100.0);

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso!");
            } else 
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000;

            Conta copia = mauricio;
            copia.saldo = 3000;

            MessageBox.Show("Mauricio: " + mauricio.saldo);
            MessageBox.Show("Copia: " + copia.saldo);

        }
    }
}

