using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Victor");
            this.contas[0].Numero = 1;

            this.contas[1].Titular = new Cliente("Mauricio");
            this.contas[1].Numero = 2;
            this.contas[1] = new Conta();

            this.contas[2] = new Conta();
            this.contas[2].Titular = new Cliente("Osni");
            this.contas[2].Numero = 3;

            /* this.conta = new Conta();
            Conta conta = new Conta();
            conta.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            conta.Titular = cliente;

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo); */
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);

            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            /*string valorDigitado = textoValor.Text;
            double valorOperação = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperação);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");*/
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            int indice = Convert.ToInt32(textoIndice.Text);

            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo); 

            /*string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");*/
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}
