using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestView
{
    public partial class Form2 : System.Windows.Forms.UserControl
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter your name please!");
            }
            else
            {
               
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new SellerView());
        }
    }
}

