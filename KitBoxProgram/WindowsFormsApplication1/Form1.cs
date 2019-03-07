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
        int n = 1 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select" & comboBox2.Text != "Select" & comboBox3.Text != "Select" & comboBox4.Text != "Select" & comboBox5.Text != "Select")
            {
                textBox7.Text = "";
                if (n < 7)
                {
                    n++;
                    textBox6.Text = "Casier " + n;
                }
                else
                {
                    textBox6.Text = "Limite atteinte";
                    button1.Enabled = false; // le rend non clickable
                    button1.Visible = false; // le rend invisible
                }
            }
            else
            {
                textBox7.Text = "Champs incomplets !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ftesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 1;
            textBox6.Text = "Casier " + n;
            button1.Enabled = true; // le rend non clickable
            button1.Visible = true; // le rend invisible
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            comboBox3.Text = "Select";
            comboBox4.Text = "Select";
            comboBox5.Text = "Select";
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
