using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string text = "";
        double data1;
        double data2;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text += "1";
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text += "2";
            textBox1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text += "3";
            textBox1.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text += "4";
            textBox1.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text += "5";
            textBox1.Text = text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text += "6";
            textBox1.Text = text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text += "7";
            textBox1.Text = text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text += "8";
            textBox1.Text = text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text += "9";
            textBox1.Text = text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            text += "0";
            textBox1.Text = text;
            if(text=="0")
            {
                text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (text != ".")
            {
                text += ".";
            }
            textBox1.Text = text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            text = "";
            textBox1.Text = "+";
            op = "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                data2 = Convert.ToDouble(text);
                double sum = data1 + data2;
                textBox1.Text = Convert.ToString(sum);
            }
            else if(op=="-")
            {
                data2 = Convert.ToDouble(text);
                double min = data1 - data2;
                textBox1.Text = Convert.ToString(min);
            }
            else if (op == "*")
            {
                data2 = Convert.ToDouble(text);
                double mult = data1 * data2;
                textBox1.Text = Convert.ToString(mult);
            }
            else if (op == "/")
            {
                data2 = Convert.ToDouble(text);
                double div = data1 / data2;
                textBox1.Text = Convert.ToString(div);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            text = "";
            textBox1.Text = "-";
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            text = "";
            textBox1.Text = "*";
            op = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            text = "";
            textBox1.Text = "/";
            op = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            data1 = 0;
            data2 = 0;
            op = "";
            text = "";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            double sq = data1 * data1;

            textBox1.Text = Convert.ToString(sq);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDouble(text);
            double cu = data1 * data1 * data1;

            textBox1.Text = Convert.ToString(cu);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
