using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double num1;
        public double num2;
        public double reslt;
        public string operador;

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            if (num1 == 0)
            {
                num1 = int.Parse(txtpantalla.Text);
            }
            else
            {
                num2 = int.Parse(txtpantalla.Text);
            }
                
            txtpantalla.Text = "";
            

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            if (num1 == 0)
            {
                num1 = int.Parse(txtpantalla.Text);
            }
            else
            {
                num2 = int.Parse(txtpantalla.Text);
            }

            txtpantalla.Text = "";

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            if (num1 == 0)
            {
                num1 = int.Parse(txtpantalla.Text);
            }
            else
            {
                num2 = int.Parse(txtpantalla.Text);
            }

            txtpantalla.Text = "";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtpantalla.Text);
            switch (operador)
            {
                case "+":
                    reslt=num1 + num2;
                    num1 = 0;
                    num2 = 0;
                    break;

                case "-":
                    reslt = num1 - num2;
                    num1 = 0;
                    num2 = 0;
                    break;

                case "*":
                    reslt = num1 * num2;
                    num1 = 0;
                    num2 = 0;
                    break;
                case "/":
                    reslt = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                    break;

            }
            txtpantalla.Text = reslt.ToString();
                   

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            if (num1 == 0)
            {
                num1 = int.Parse(txtpantalla.Text);
            }
            else
            {
                num2 = int.Parse(txtpantalla.Text);
            }

            txtpantalla.Text = "";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + ".";
        }

        
    }
}
