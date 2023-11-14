using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void escolhaOperador(int numero, string operadorEscolhido)
        {
            lbtemp.Text = numero.ToString();
            lboperador.Text = operadorEscolhido;
            txbnumero1.Text = "";
        }
        public double calculos(double num1, double num2, string operador) 
        {
            double resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;

            }
            else if (operador == "X")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/" )
            {
                resultado = num1 / num2;
            }
            else  if (operador == "resto")
            {
                resultado = num1 % num2;
            }
            else if (operador == "%")
            {
                double porcentagem = num1/100;
                resultado = num2 * porcentagem;
            }
            
            return resultado;

        }
        private void btnmais_Click(object sender, EventArgs e)
        {

            if (txbnumero1.Text != "" && txbnumero1.Text != "error") 
            { 
            int numero1 = int.Parse(txbnumero1.Text);
            //int numero2 = 0;

            Button botao = (Button)sender;
            string operadorselecionado = botao.Text;

               


            //int total;
            //total = calculos(numero1, numero2, operadorselecionado);
            //lbresultado.Text = "O resultado é " + total.ToString();

            escolhaOperador(numero1, operadorselecionado);
        }
            else
            {
                lbtemp.Text = "error";
            }
    }


        private void bnt0_Click(object sender, EventArgs e)
        {
            Button valorBotao = (Button)sender;
            //MessageBox.Show(valorBotao.Text);

            //txbnumero1.Text = txbnumero1.Text + valorBotao.Text;

            txbnumero1.Text += valorBotao.Text;

            if (valorBotao.Text == "C")
            {
                txbnumero1.Text = "";
            }

            else if (valorBotao.Text == "CE")
            {
                txbnumero1.Text = "";
                lbtemp.Text = "";
                lboperador.Text = "";
            }
           
        }

        private void bntigual_Click(object sender, EventArgs e)
        {
            int primeiro_numero = int.Parse(lbtemp.Text);
            int segundo_numero = int.Parse(txbnumero1.Text);
            string operador = lboperador.Text;

            double total = calculos(primeiro_numero, segundo_numero, operador);

            txbnumero1.Text = total.ToString();
        }

        private void btnnegativo_Click(object sender, EventArgs e)
        {
            double numero = int.Parse(txbnumero1.Text);
            double result = numero * -1;
            txbnumero1.Text = result.ToString();

        }
    }
}
