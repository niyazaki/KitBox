using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string calcul;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button_click(object sender, MouseEventArgs e)
        {
            test();
        }

        private void fonction(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                test();
            }
        }


        private void test() //fonction perso
        {
            string var1 = textBox1.Text;
            try
            {
                var result = new DataTable().Compute(var1, null); //transforme le string en equation int 
                textBox2.AppendText(">" + var1 + "\r\n" + result + "\n");
                textBox1.Text = "";
            }
            catch
            {
                textBox2.AppendText(">Erreur : veuillez entrer une opération mathématique correcte.\n");
                textBox1.Text="";
            }
        }
    }
}
