using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitBoxProgram;
//Note: GenerateMember dans Propreties doit être True sinon la variable est invisible dans le code

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int n = 1 ;
        bool finished = false;
        List<int> longueur = new List<int>();
        List<int> largeur = new List<int>();
        List<int> hauteur = new List<int>();
        List<string> couleurPortes = new List<string>();
        List<string> couleurPanneaux = new List<string>();

        DB db = new DB();


        SearchClass s = new SearchClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.OpenCo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select" & comboBox2.Text != "Select" & comboBox3.Text != "Select" & comboBox4.Text != "Select" & comboBox5.Text != "Select")
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                comboBox2.Visible = false;
                comboBox4.Visible = false;

                textBox7.Text = "";
                if (n < 7)
                {
                    n++;
                    textBox6.Text = "Casier " + n;
                    hauteur.Add(Convert.ToInt32(comboBox1.Text));
                    longueur.Add(Convert.ToInt32(comboBox2.Text));
                    largeur.Add(Convert.ToInt32(comboBox4.Text));
                    couleurPortes.Add(comboBox3.Text);
                    couleurPanneaux.Add(comboBox5.Text);
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
            textBox7.Text = "Commande terminée !";
            button5.Visible = false;
            button1.Visible = false;
            button4.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            textBox6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            finished = true;
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
            button5.Visible = true;
            button1.Visible = false;
            button4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox6.Visible = true;
            textBox6.Text = "Récapitulatif";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;

            longueur.Add(0);
            largeur.Add(0);
 
            int m = 0;
            while (m != (n-1))
            {

                textBox8.Text += "\r\nCasier" + (m+1)+" : Hauteur: "+hauteur[m]+" ; Couleur des portes:  "+couleurPortes[m] + " ; Couleur des panneaux: "+couleurPanneaux[0]+"\r\n";
                m++;

            }
            textBox9.Text += "\r\n Largeur de chaque casier: " + largeur[0];
            textBox9.Text += " ; et longueur  de chaque casier: " + longueur[0];    
            textBox9.Text += "\r\n Largeur totale : " + (largeur[0]);
            textBox9.Text += "\r\n Longueur totale : " + (longueur[0]);
            int hauteurtotale = 0;
            foreach (int x in hauteur)
            {
                hauteurtotale += x;
            }
            textBox9.Text += "\r\n Hauteur totale : " + (hauteurtotale);


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
            foreach (string i in s.Search("TRG", "depth", "Accessory"))
            {
                comboBox2.Items.Add(i);
            }
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
            textBox6.Visible = true;
            textBox6.Text = "Casier " + n;
            button1.Enabled = true; // le rend clickable
            button1.Visible = true; // le rend visible
            textBox2.Visible = true;
            textBox3.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            comboBox3.Text = "Select";
            comboBox4.Text = "Select";
            comboBox5.Text = "Select";
            List<int> longueur = new List<int>();
            List<int> largeur = new List<int>();
            List<int> hauteur = new List<int>();
            List<string> couleurPortes = new List<string>();
            List<string> couleurPanneaux = new List<string>();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (finished == false)
            {
                textBox6.Text = "Casier " + n;
                button5.Visible = false;
                button1.Visible = true;
                button4.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox9.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                textBox6.Visible = true;
                textBox9.Text = "";
            }
            else
            {
                textBox7.Text = "Commande terminée !";
                button5.Visible = false;
                button1.Visible = false;
                button4.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                textBox6.Text = "";
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox9.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                textBox6.Visible = false;
                textBox9.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
