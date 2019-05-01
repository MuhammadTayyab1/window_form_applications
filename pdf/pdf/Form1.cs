using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace pdf
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
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("mypdf900.pdf",FileMode.Create));
            doc.Open();

            Paragraph a = new Paragraph("\n\n                                                          INVOICE");
            doc.Add(a);

            Paragraph p =  new Paragraph("                                             **** Your Shop Name **** \n\n");
            doc.Add(p);

            Paragraph p1 = new Paragraph("                  Date  :  " + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
            doc.Add(p1);

            Paragraph p2 = new Paragraph("                  Time  :  "+DateTime.Now.ToString("HH:mm:ss")+"\n");
            doc.Add(p2);

            Paragraph p90 = new Paragraph("                  Invoice number  :  90878978\n\n");
            doc.Add(p90);

            Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");
            doc.Add(p3);

            Paragraph p4 = new Paragraph("                  Customer Name  :  Ali raza\n");
            doc.Add(p4);

            Paragraph p5 = new Paragraph("                  Total Items    :  10\n");
            doc.Add(p5);

            Paragraph p6 = new Paragraph("                  Price / Item   :  98.99\n");
            doc.Add(p6);

            Paragraph p7 = new Paragraph("                  Total amount  :  980.99\n\n");
            doc.Add(p7);

            Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");
            doc.Add(p8);

            Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");
            doc.Add(p9);

            Paragraph p10 = new Paragraph("                  Contact us : 1234567890 \n\n");
            doc.Add(p10);

            Paragraph pl = new Paragraph("                   copyright all rights reserved CMT softwares soltion ");
            doc.Add(pl);

            Paragraph pq = new Paragraph("                   https://sites.google.com/view/cmt-softwares-solution/home ");
            doc.Add(pq);



            doc.Close();
        }
    }
}
