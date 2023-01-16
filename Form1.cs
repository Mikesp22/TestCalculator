using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public virtual int Suma(int op1, int op2)
        {
            return op1 + op2;
        }

        static int Resta(int op1, int op2)
        {
            return op1 - op2;
        }


        static int Mult(int op1, int op2)
        {
            return op1 * op2;
        }

        static double Div(int op1, int op2)
        {
            return op1 / op2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<int, int, int> Sumar = Suma;
            textBox3.Text = Sumar(Convert.ToInt32(s1.Text), Convert.ToInt32(s2.Text)).ToString();

        }



        public class CalculatorSi : Calculator
        {
            public double Exponente(double dBase, double dExp)
            {
                return Math.Pow(dBase, dExp);
            }
        }



            private void button2_Click(object sender, EventArgs e)
        {
            Func<int, int, int> Restar = Resta;
            textBox4.Text = Restar(Convert.ToInt32(r1.Text), Convert.ToInt32(r2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Func<int, int, int> Multiplicar = Mult;
            textBox7.Text = Multiplicar(Convert.ToInt32(m1.Text), Convert.ToInt32(m2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Func<int, int, double> Dividir = Div;
            textBox10.Text = Dividir(Convert.ToInt32(d1.Text), Convert.ToInt32(d2.Text)).ToString();
        }
    }
}
