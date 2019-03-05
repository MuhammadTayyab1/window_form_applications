using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float start = float.Parse(textBox1.Text);
            float end = float.Parse(textBox2.Text);
            float diff = float.Parse(textBox3.Text);
            string save = "";

            for (float i = start; i <=end; i+=diff)
            {
                if (radioButton1.Checked == true)
                {
                    float a= ((i*i)-1);
                    save += "           X = " + i + "                      Y = " + a+"\n";
                }
                else if (radioButton2.Checked == true)
                {
                    float a = ((2 * i) - 1);
                    save += "           X = " + i + "                      Y = " + a + "\n";
                }
                else if (radioButton3.Checked == true)
                {
                    float a = (2 - (i * i));
                    save += "           X = " + i + "                      Y = " + a + "\n";
                }
                else if (radioButton4.Checked == true)
                {
                    float a = 1 / i;
                    save += "           X = " + i + "                      Y = " + a + "\n";
                }
                else if (radioButton5.Checked == true)
                {
                    float a = 1 / ((i*i)-4);
                    save += "           X = " + i + "                      Y = " + a + "\n";
                }
                else
                {
                    save = "Try again";
                }
            }

            richTextBox1.Text = save;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox4.Text);
            float b= a*a;
            richTextBox1.Text = "  Square of  "+a+"  is  =  " + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox5.Text);
            float b = a * a * a;
            richTextBox1.Text = "  Cube of  " + a + "  is  =  " + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox6.Text);

            string save = "                      Table of"+a+"\n\n";

            for (int i = 1; i <= 10; i++)
            {
                int b = i * a;
                save += "             "+a + "   X   " + i + "   =   " + b+"\n";
            }
            richTextBox1.Text = save;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(textBox8.Text);
            int c = int.Parse(textBox9.Text);
            string save = "";
            Random r = new Random();

            for (int i = 0; i <=c; i++)
            {
                int q = r.Next(a, b);
                save += "                  " + q+"\n";
            }

            richTextBox1.Text = save;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = textBox10.Text;
            int b= (int)a[0];

            richTextBox1.Text = "\n\n             ASCII code of   " + a + "   is  =    " + b;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox11.Text);
            float b = a * 139.90f;
            richTextBox1.Text = " \n\n        " + a + " Dollar is   =   " + b + "  PKR";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox12.Text);
            float b = a / 139.90f;
            richTextBox1.Text = " \n\n        " + a + "  PKR  is   =   " + b + "  Dollar";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox13.Text);
            float b = a * 20.66f;
            richTextBox1.Text = " \n\n        " + a + " Yuan is   =   " + b + "  PKR";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox14.Text);
            float b = a / 20.66f;
            richTextBox1.Text = " \n\n        " + a + " PKR is   =   " + b + "  Yuan";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
