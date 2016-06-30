using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesenvolvendoCaixaEletronico
{

    public partial class Form1 : Form
    {
        Conta conta;
        Cliente cliente;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new Conta();
            cliente = new Cliente();

            conta.Titular = cliente;
            conta.Deposita(3000);
            conta.Saca(1000);
            conta.Titular.Nome = "Vinicius Trovão";
            conta.Numero = 1;
            conta.Titular.Cpf = "12474237700";
            conta.Titular.Telefone = "33908463";


        }

        private void btnBuscarInfos_Click(object sender, EventArgs e)
        {


            //        MessageBox.Show("Informações do cliente: \nNome: " + conta.Titular.Nome +
            //            "\nNúmero da conta: " + conta.Numero + "\nSaldo: " + conta.Saldo);


            string numeroConta = Convert.ToString(conta.Numero);
            string nomeCliente = conta.Titular.Nome;
            string cpfCliente = conta.Titular.Cpf;
            string saldoCliente = Convert.ToString(conta.Saldo);

            txtBoxNumero.Text = numeroConta;
            txtNomeCliente.Text = nomeCliente;
            txtBoxCpf.Text = cpfCliente;
            txtBoxSaldo.Text = saldoCliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
