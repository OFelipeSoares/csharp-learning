using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        List<Type> classList;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

           classList = new List<Type>
            {
                typeof(ContaCorrente),
                typeof(ContaPoupanca)
            };

           
            comboTipoConta.DataSource = classList; 

            comboTipoConta.DisplayMember = "Name";
            

        } 
        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Type selectedType = (Type) comboTipoConta.SelectedItem;
            Conta novaConta = (Conta)Activator.CreateInstance(selectedType);

            //Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);

            MessageBox.Show("Conta criada com sucesso! Você já pode fechar essa aba");



        }
    }
}
