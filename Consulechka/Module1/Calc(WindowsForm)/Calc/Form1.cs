using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0, b = 0, c = 0;
        char sign = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (sign)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
                case '^': c = Math.Pow(a, b);
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            fact(a);
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            sign = (sender as Button).Text[0];
            textBox1.Clear();
        }
        public void fact(double a)
        {
            //n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= a; i++)
            {
                factorial = factorial * i;
            }
            textBox1.Text = factorial.ToString();
            return;
            //Console.WriteLine("Факториал числа " + n + " = " + factorial);
            //Console.ReadKey();
        }
    }
}
