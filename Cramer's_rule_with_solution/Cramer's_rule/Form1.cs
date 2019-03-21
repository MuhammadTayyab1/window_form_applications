using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cramer_s_rule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = Convert.ToInt32(textBox1.Text);
                int a2 = Convert.ToInt32(textBox2.Text);
                int a3 = Convert.ToInt32(textBox3.Text);
                int a4 = Convert.ToInt32(textBox4.Text);
                int a5 = Convert.ToInt32(textBox5.Text);
                int a6 = Convert.ToInt32(textBox6.Text);
                int a7 = Convert.ToInt32(textBox7.Text);
                int a8 = Convert.ToInt32(textBox8.Text);
                int a9 = Convert.ToInt32(textBox9.Text);

                int a10 = Convert.ToInt32(textBox10.Text);
                int a11 = Convert.ToInt32(textBox11.Text);
                int a12 = Convert.ToInt32(textBox12.Text);

                int R = a1 * ((a8 * a6) - (a5 * a9)) - a2 * ((a6 * a7) - (a4 * a9)) + a3 * ((a7 * a5) - (a4 * a8));

                int A = a10 * ((a8 * a6) - (a5 * a9)) - a2 * ((a12 * a6) - (a11 * a9)) + a3 * ((a12 * a5) - (a11 * a8));

                int B = a1 * ((a12 * a6) - (a11 * a9)) - a10 * ((a7 * a6) - (a4 * a9)) + a3 * ((a7 * a11) - (a4 * a12));

                int C = a1 * ((a8 * a11) - (a5 * a12)) - a2 * ((a7 * a11) - (a4 * a12)) + a10 * ((a7 * a5) - (a4 * a8));


                int x = A / R;
                int y = B / R;
                int z = C / R;

                textBox13.Text = Convert.ToString(x);
                textBox14.Text = Convert.ToString(y);
                textBox15.Text = Convert.ToString(z);


                String save = "                                  Solution                     \n\n\n";

                save +="       "+a1+"      "+a2+"      "+a3+"\n";
                save += "\n";
                save +="       "+a4+"      "+a5+"      "+a6+"\n";
                save +="\n";
                save +="       "+a7+"      "+a8+"      "+a9+"\n";
                save += "\n\n\n";
                save += "  R = " + a1 + " X ((" + a8 + " X " + a6 + ") - (" + a5 + " X " + a9 + ")) - " + a2 + " X ((" + a6 + " X " + a7 + ") - (" + a4 + " X " + a9 + ")) + " + a3 + " X (" + a7 + " X " + a5 + ") - (" + a4 + " X " + a8 + "))\n\n";
                save += "  R = " + a1 + " X (" + a8 * a6 + " - " + (a5 * a9) + ") - " + a2 + " X (" + (a6 * a7) + " - " + (a4 * a9) + ") + " + a3 + " X (" + (a7 * a5) + " - " + (a4 * a8) + ")\n\n";
                save += "  R = " + a1 + " X (" + ((a8 * a6) - (a5 * a9)) + ")  - " + a2 + " X (" + ((a6 * a7) - (a4 * a9)) + ") + " + a3 + " X (" + ((a7 * a5) - (a4 * a8)) + ")\n\n";
                save += "  R = " + R+"\n\n\n\n\n";



                save += "       " + a10 + "      " + a2 + "      " + a3 + "\n";
                save += "\n";
                save += "       " + a11 + "      " + a5 + "      " + a6 + "\n";
                save += "\n";
                save += "       " + a12 + "      " + a8 + "      " + a9 + "\n";
                save += "\n\n\n";
                save += "  A = " + a10 + " X ((" + a8 + " X " + a6 + ") - (" + a5 + " X " + a9 + ")) - " + a2 + " X ((" + a6 + " X " + a12 + ") - (" + a11 + " X " + a9 + ")) + " + a3 + " X (" + a12 + " X " + a5 + ") - (" + a11 + " X " + a8 + "))\n\n";
                save += "  A = " + a10 + " X (" + a8 * a6 + " - " + (a5 * a9) + ") - " + a2 + " X (" + (a6 * a12) + " - " + (a11 * a9) + ") + " + a3 + " X (" + (a12 * a5) + " - " + (a11 * a8) + ")\n\n";
                save += "  A = " + a10 + " X (" + ((a8 * a6) - (a5 * a9)) + ")  - " + a2 + " X (" + ((a6 * a12) - (a11 * a9)) + ") + " + a3 + " X (" + ((a12 * a5) - (a11 * a8)) + ")\n\n";
                save += "  A = " + A + "\n\n\n\n\n";


                save += "       " + a1 + "      " + a10 + "      " + a3 + "\n";
                save += "\n";
                save += "       " + a4 + "      " + a11 + "      " + a6 + "\n";
                save += "\n";
                save += "       " + a7 + "      " + a12 + "      " + a9 + "\n";
                save += "\n\n\n";
                save += "  B = " + a1 + " X ((" + a12 + " X " + a6 + ") - (" + a11 + " X " + a9 + ")) - " + a10 + " X ((" + a6 + " X " + a7 + ") - (" + a4 + " X " + a9 + ")) + " + a3 + " X (" + a7 + " X " + a11 + ") - (" + a4 + " X " + a12 + "))\n\n";
                save += "  B = " + a1 + " X (" + a12 * a6 + " - " + (a11 * a9) + ") - " + a10 + " X (" + (a6 * a7) + " - " + (a4 * a9) + ") + " + a3 + " X (" + (a7 * a11) + " - " + (a4 * a12) + ")\n\n";
                save += "  B = " + a1 + " X (" + ((a12 * a6) - (a11 * a9)) + ")  - " + a10 + " X (" + ((a6 * a7) - (a4 * a9)) + ") + " + a3 + " X (" + ((a7 * a11) - (a4 * a12)) + ")\n\n";
                save += "  B = " + B + "\n\n\n\n\n";


                save += "       " + a1 + "      " + a2 + "      " + a10 + "\n";
                save += "\n";
                save += "       " + a4 + "      " + a5 + "      " + a11 + "\n";
                save += "\n";
                save += "       " + a7 + "      " + a8 + "      " + a12 + "\n";
                save += "\n\n\n";
                save += "  C = " + a1 + " X ((" + a8 + " X " + a11 + ") - (" + a5 + " X " + a12 + ")) - " + a2 + " X ((" + a11 + " X " + a7 + ") - (" + a4 + " X " + a12 + ")) + " + a10 + " X (" + a7 + " X " + a5 + ") - (" + a4 + " X " + a8 + "))\n\n";
                save += "  C = " + a1 + " X (" + a8 * a11 + " - " + (a5 * a12) + ") - " + a2 + " X (" + (a11 * a7) + " - " + (a4 * a12) + ") + " + a10 + " X (" + (a7 * a5) + " - " + (a4 * a8) + ")\n\n";
                save += "  C = " + a1 + " X (" + ((a8 * a11) - (a5 * a12)) + ")  - " + a2 + " X (" + ((a11 * a7) - (a4 * a12)) + ") + " + a10 + " X (" + ((a7 * a5) - (a4 * a8)) + ")\n\n";
                save += "  C = " + C + "\n\n\n\n\n";

                save += "  X = A / R \n\n";
                save += "  X = " + A + " / " + R + "\n\n";
                save += "  X = " + x + "\n\n\n\n";

                save += "  Y = B / R \n\n";
                save += "  Y = " + B + " / " + R + "\n\n";
                save += "  Y = " + y + "\n\n\n\n";

                save += "  Z = C / R \n\n";
                save += "  Z = " + C + " / " + R + "\n\n";
                save += "  Z = " + z + "\n";

                richTextBox1.Text = save;

                FileStream fs = new FileStream("solution.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                for (int i = 0; i < save.Length; i++)
                {
                    fs.WriteByte((byte)save[i]);
                }
            }
            catch
            {
                MessageBox.Show("Please fill all boxes . enter 0 where have no values");
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
