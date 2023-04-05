using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        //private Conta[] contas;
        private List<Conta> contas = new List<Conta>();

        private int numeroDeContas;

        public void AdicionaConta(Conta conta)
        {
            //this.contas[this.numeroDeContas] = conta;
            //this.numeroDeContas++;
            contas.Add(conta);
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);
        }
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //contas = new Conta[3];
            this.numeroDeContas = 0;
            //this.contas = new Conta[100];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new Conta();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);


            Conta c3 = new Conta();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            
            foreach (Conta c in contas)
            {
                if (c != null)
                {

                    //comboContas.Items.Add("Titular: " + c.Titular.Nome);
                    comboDestinoTransferencia.Items.Add("Titular: " + c.Titular.Nome);
                }

            }
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            //int indice = Convert.ToInt32(textoIndice.Text);
            int indice = comboContas.SelectedIndex;

            if (indice >= 0)
            {

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
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            //int indice = Convert.ToInt32(textoIndice.Text);
            int indice = comboContas.SelectedIndex;

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

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboDestinoTransferencia.SelectedIndex;
            Conta selecionada = contas[indice];
        }

        private void botaotransfere_Click(object sender, EventArgs e)
        {
            int destino = comboDestinoTransferencia.SelectedIndex;
            int origem = comboContas.SelectedIndex;

            Conta contaOrigem = contas[origem];
            Conta contaDestino = contas[destino];

            double valor = Convert.ToDouble(textoValor.Text);
            //contaOrigem.Saca(valor);
            //contaDestino.Deposita(valor);
            contaOrigem.Transfere(valor, contaDestino);

            textoSaldo.Text = Convert.ToString(contaOrigem.Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCaastro = new FormCadastroConta(this);

            formularioDeCaastro.ShowDialog();
        }
    }
}
