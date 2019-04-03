using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KitBoxProgram;
using WindowsFormsApp7;
using System.Windows.Forms;

namespace Start
{
    public partial class Start : System.Windows.Forms.UserControl
    {
        Form1 form = new Form1();
        MySqlCommand cmd = new MySqlCommand();
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter your name please");
            }
            else
            {
                this.Controls.Clear();
                this.Controls.Add(new View() );

            }
        }
    }
}
