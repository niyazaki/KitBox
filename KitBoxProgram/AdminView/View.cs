using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using KitBoxProgram;
using AdminView;

//Note: GenerateMember dans Propreties doit être True sinon la variable est invisible dans le code

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        int n = 1 ;
        int p = 0;
        bool finished = false;
        List<int> longueur = new List<int>();
        List<int> largeur = new List<int>();
        List<int> hauteur = new List<int>();
        List<string> couleurPortes = new List<string>();
        List<string> couleurPanneaux = new List<string>();
        List<string> couleurCorniere = new List<string>();
        List<string> choixCorniere = new List<string>();
        int change = 1; //permettra de savoir si oui ou non on veut des portes
        DB db = new DB();
        public int hauteurtotale;
        public void Display()
        {
            textBox7.Text = "";
            textBox9.Text = "";
            int m = 0;
            while (m != (n - 1))
            {
                
                textBox9.Text += "\r\nCasier" + (m + 1) + " : Hauteur: " + hauteur[m] + " ; Couleur des portes:  " + couleurPortes[m] + " ; Couleur des panneaux: " + couleurPanneaux[0] + "\r\n";
                m++;

            }
            textBox9.Text += "\r\n Largeur de chaque casier: " + largeur[0];
            textBox9.Text += " ; et longueur  de chaque casier: " + longueur[0];
            textBox9.Text += "\r\n Couleur des cornières : " + (couleurCorniere[0]);
            hauteurtotale = 0;
            foreach (int x in hauteur)
            {
                hauteurtotale += x;
            }
            textBox9.Text += "\r\n Hauteur totale : " + (hauteurtotale);
        }
        public void Display13()
        {
            textBox7.Text = "";
            textBox13.Text = "";
            int m = 0;
            while (m != (n - 1))
            {

                textBox13.Text += "\r\nCasier" + (m + 1) + " : Hauteur: " + hauteur[m] + " ; Couleur des portes:  " + couleurPortes[m] + " ; Couleur des panneaux: " + couleurPanneaux[0] + "\r\n";
                m++;

            }
            textBox13.Text += "\r\n Largeur de chaque casier: " + largeur[0];
            textBox13.Text += " ; et longueur  de chaque casier: " + longueur[0];
            textBox13.Text += "\r\n Couleur des cornières : " + couleurCorniere[0];
            int hauteurtotale = 0;
            foreach (int x in hauteur)
            {
                hauteurtotale += x;
            }
            int prix = 0;
            textBox13.Text += "\r\n Hauteur totale : " + (hauteurtotale);
            textBox13.Text += "\r\n Choix des cornières : " + choixCorniere[0];
            textBox13.Text += "\r\n Prix total : " + prix + "€";
        }


        public SearchClass s = new SearchClass();
        private bool a;

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
            if (comboBox1.Text != ""  & comboBox5.Text != "" & (comboBox3.Text != "" | change ==1) )
            {
                Cleat Tasseau = new Cleat(Int32.Parse(comboBox1.Text));
                UDpanel PanneauHB = new UDpanel(comboBox5.Text, Int32.Parse(comboBox4.Text), Int32.Parse(comboBox2.Text));
                LRpanel PanneauGD = new LRpanel(comboBox5.Text, Int32.Parse(comboBox2.Text), Int32.Parse(comboBox1.Text));
                BApanel PanneauAR = new BApanel(comboBox5.Text, Int32.Parse(comboBox4.Text), Int32.Parse(comboBox1.Text));

                textBox2.Visible = false;
                textBox3.Visible = false;
                comboBox2.Visible = false;
                comboBox4.Visible = false;

                textBox7.Text = "";
                if (p < 7)
                {
                    n++;
                    textBox6.Text = "Casier " + n;
                    hauteur.Add(Convert.ToInt32(comboBox1.Text) + 4);
                    if (change == 1)
                    {
                        couleurPortes.Add("Pas de porte");
                    }
                    else
                    {
                        couleurPortes.Add(comboBox3.Text);
                    }
                    couleurPanneaux.Add(comboBox5.Text);
                    p++;
                    if (p ==7)
                    {
                        textBox6.Text = "Limite atteinte";
                        button1.Enabled = false;
                    }
                }
                else
                {
                    textBox6.Text = "Limite atteinte";
                    button1.Enabled = false; // le rend non clickable
                }
            }
            else
            {
                textBox7.Text = "Champs incomplets !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                tabControl1.SelectedTab = Box;
                button4.Enabled = true;
                couleurCorniere.Add(comboBox7.Text);
            }
            else
            {
                textBox7.Text = "Champs incomplets !";
            }
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
            tabControl1.SelectedTab = Recap;

            longueur.Add(0);
            largeur.Add(0);

            Display();


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
            textBox7.Text = "";
            n = 1;
            p = 0;
            textBox6.Visible = true;
            textBox6.Text = "Casier " + n;
            button1.Enabled = true; // le rend clickable
            button1.Visible = true; // le rend visible
            textBox2.Visible = true;
            textBox3.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            List<int> longueur = new List<int>();
            List<int> largeur = new List<int>();
            List<int> hauteur = new List<int>();
            List<string> couleurPortes = new List<string>();
            List<string> couleurPanneaux = new List<string>();
            List<string> couleurCorniere = new List<string>();
            tabControl1.SelectedTab = Main;
            button4.Enabled = false;

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Box;
            
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StoreKeeper;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Seller;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Base;
            List<string> listWidth = new List<string> {};
            listWidth = s.Search("TRF", "width", "Catalogue");
            foreach (string i in listWidth)
            {
                comboBox4.Items.Add(i);
            }

            List<string> listDepth = new List<string> {};
            listDepth = s.Search("TRG", "depth", "Catalogue");
            foreach (string i in listDepth)
            {
                comboBox2.Items.Add(i);
            }


            //Partie masquée car crash, je l'ai laissée en suspens pour les tests visuels
            //Faudra l'exploiter une fois le bug résolue pour afficher les elements dans comboBox Longueur
            //foreach (string i in s.Search("TRG", "depth", "Accessory"))
            //{
            // comboBox2.Items.Add(i);
            // }

            // A MODIFIER pour le comboBox Largeur, crash aussi pour l'instant
            //foreach (string i in s.Search("TRG", "depth", "Accessory"))
            //{
            // comboBox4.Items.Add(i);
            // }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0,1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand("select * from Command ;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             
            if (comboBox2.Text != "" & comboBox4.Text != "")
            {
                LRrail lrRail = new LRrail(Int32.Parse(comboBox2.Text));
                FRrail frRail = new FRrail(Int32.Parse(comboBox4.Text));
                BArail baRail = new BArail(Int32.Parse(comboBox4.Text));


                textBox7.Text = "";
                List<string> listHeight = new List<string> {};
                listHeight = s.Search("TRG", "height", "accessory");
                foreach (string i in listHeight)
                {
                    comboBox1.Items.Add(i);
                }

                List<string> listColor = new List<string> { };
                listColor = s.Search("PAH" + lrRail.depth.ToString() + frRail.width.ToString(), "color", "accessory");  //boxDepth ou box.Depth (attention au type) etc..
                foreach (string i in listColor)
                {
                    comboBox5.Items.Add(i);
                }

                //Mettre portes dans un autre onglet car il nous faut la hauteur obtenue dans l'onglet box
                List<string> listDoor = new List<string> {};
                listDoor = s.Search("POR" + comboBox1.Text + frRail.width.ToString(), "color", "accessory");  //boxHeight ou box.Height (attention au type) etc..
                foreach (string i in listColor)
                {
                    comboBox3.Items.Add(i);
                }

                tabControl1.SelectedTab = Box;
                //Faut ajouter aussi fonction search ici pour que quand on clique sur le bouton
                //et qu'on passe à l'onglet Corniere, ça fait une recherche pour remplir le comboBox7
                //qui correspond à la couleur des cornières
            }
            else
            {
                textBox7.Text = "Champs incomplets !";
            }
        }


        private void Box_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
            if (change==1) {
                textBox4.Visible = true;
                comboBox3.Visible = true;
                change = 0;
            }
            else
            {
                textBox4.Visible = false;
                comboBox3.Visible = false;
                change = 1;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> listCor = new List<string> { };
            //Trouver la hauteur totale à prendre pour notre armoire :
            List<string> listTotHeight = new List<string> { };
            listTotHeight = s.Search("COR", "height", "accessory");
            int i = 0;
            int corHeight = 0;
            while (Int32.Parse(listTotHeight[i]) >= hauteurtotale)
            {
                corHeight = Int32.Parse(listTotHeight[i]);
                i++;
            }
            
            listCor = s.Search("COR" + Convert.ToString(corHeight), "color", "accessory");
            foreach (string j in listCor)
            {
                comboBoxH.Items.Add(i);
            }


            tabControl1.SelectedTab = End;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand("select * from Command ;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);
                button11.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox10.Text + "--->" + comboBox6.Text;
                string instruction = "update Command d set d.Payed = \'" + comboBox6.Text + "\' where ID_Command= CONVERT(" + textBox10.Text + ",UNSIGNED INTEGER); SELECT * from Command d";

                MySqlCommand commandDB = new MySqlCommand(instruction, myConn);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = commandDB;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView2.DataSource = bSource;
                    sda.Update(dbdataset);
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    textBox7.Text = "Champs invalides !";
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand("select * from Command d where d.Payed=\'Payed\';", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                tabControl1.SelectedTab = Main;
                textBox7.Text = "";
                n = 1;
                p = 0;
                textBox6.Visible = true;
                textBox6.Text = "Casier " + n;
                button1.Enabled = true; // le rend clickable
                button1.Visible = true; // le rend visible
                textBox2.Visible = true;
                textBox3.Visible = true;
                comboBox2.Visible = true;
                comboBox4.Visible = true;
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                List<int> longueur = new List<int>();
                List<int> largeur = new List<int>();
                List<int> hauteur = new List<int>();
                List<string> couleurPortes = new List<string>();
                List<string> couleurPanneaux = new List<string>();
                List<string> couleurCorniere = new List<string>();
                List<string> choixCorniere = new List<string>();
                tabControl1.SelectedTab = Main;
                button4.Enabled = false;
            }
            else if (dialogresult == DialogResult.Cancel)
            {
            }
            popup.Dispose();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (comboBoxH.Text != "")
            {
                finished = true;
                tabControl1.SelectedTab = CommandDetail;
                Display13();
            }
            else
            {
                textBox7.Text = "Champs incomplets !";
            }
        }
    }
}
