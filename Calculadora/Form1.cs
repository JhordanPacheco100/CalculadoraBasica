
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double valor1;
        private double valor2;
        private double Resultado;
        private string operacion;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        private void buttonMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox1.Text);
            switch (operacion)
            {
                case "*":
                    Resultado = valor1 * valor2;
                    break;
                case "+":
                    Resultado = valor1 + valor2;
                    break;
                case "-":
                    Resultado = valor1 - valor2;
                    break;
                case "/":
                    Resultado = valor1 / valor2;
                    break;
            }
            textBox1.Text = Resultado.ToString();
        }
    }
}
