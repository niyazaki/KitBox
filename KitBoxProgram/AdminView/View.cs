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
using System.IO;

//Note: GenerateMember dans Propreties doit être True sinon la variable est invisible dans le code

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        int n = 1 ;
        int p = 0;
        int corHeight;
        string Id_Customer;
        string Id_Angle;
        string Id_Cabinet;
        string Id_Command;
        List<int> profondeur = new List<int>();
        List<int> largeur = new List<int>();
        List<int> hauteur = new List<int>();
        List<string> couleurPortes = new List<string>();
        List<string> couleurPanneaux = new List<string>();
        List<string> couleurCorniere = new List<string>();
        List<string> choixCorniere = new List<string>();
        List<bool> coupelles = new List<bool>();
        bool finished = false;
        int change = 1; //permettra de savoir si oui ou non on veut des portes
        DB db = new DB();
        public int hauteurtotale;
        public void Display()
        {
            textBox7.Text = "";
            textBox9.Text = "Box N°    Height       Color of Doors      Color of panels"; ;
            int m = 0;
            while (m != (n - 1))
            {
                
                textBox9.Text += "\r\n" + (m + 1) + "  :               " + hauteur[m] + "                " + couleurPortes[m] + "                       " + couleurPanneaux[m] + "\r\n";
                m++;

            }
            textBox9.Text += "\r\n Cabinet's width: " + largeur[0];
            textBox9.Text += " ; cabinet's depth: " + profondeur[0];
            hauteurtotale = 0;
            foreach (int x in hauteur)
            {
                hauteurtotale += x;
            }
            textBox9.Text += "\r\n Total height : " + (hauteurtotale);
        }
        public void Display13()
        {
            textBox7.Text = "";
            textBox13.Text = "Thank you for your command ! Here are the details of it : \r\nBox N°    Height       Color of Doors      Color of panels";
            int m = 0;
            float price = 0;
            while (m != (n - 1))
            {
                textBox13.Text += "\r\n" + (m + 1) + "  :               " + hauteur[m] + "                " + couleurPortes[m] + "                       " + couleurPanneaux[m] + "\r\n";

                price += 4 * float.Parse(db.SearchPrice("Cleat", hauteur[m]-4, 0, 0));
                price += 2 * float.Parse(db.SearchPrice("LR Panel", hauteur[m]-4, profondeur[0], 0, couleurPanneaux[m]));
                price += float.Parse(db.SearchPrice("BA Panel", hauteur[m]-4, 0, largeur[0], couleurPanneaux[m]));
                price += 2 * float.Parse(db.SearchPrice("UD Panel", 0, profondeur[0], largeur[0], couleurPanneaux[m]));
                price += 2 * float.Parse(db.SearchPrice("BA Rail", 0, 0, largeur[0]));
                price += 2 * float.Parse(db.SearchPrice("Fr Rail", 0, 0, largeur[0]));
                price += 4 * float.Parse(db.SearchPrice("Lr Rail", 0, profondeur[0], 0));
                if (coupelles[m] == true)
                {
                    price += 2 * float.Parse(db.SearchPrice("Coupelles", 0, 0, 0));
                }
                if (couleurPortes[m] != "No door")
                {
                    price += 2 * float.Parse(db.SearchPrice("Door", hauteur[m]-4, 0, largeur[0], couleurPortes[m]));
                }
                m++;
            }
            if ((n-1) != 0)
            {
                price += 4 * float.Parse(db.SearchPrice("Angle", corHeight, 0, 0, couleurCorniere[0]));
            }

            textBox13.Text += "\r\n Cabinet's width: " + largeur[0];
            textBox13.Text += " ; cabinet's depth: " + profondeur[0];
            textBox13.Text += "\r\n Color of angles : " + couleurCorniere[0];
            int hauteurtotale = 0;
            foreach (int x in hauteur)
            {
                hauteurtotale += x;
            }
            textBox13.Text += "\r\n Total height : " + (hauteurtotale);
            textBox13.Text += "\r\n Total Price : " + price + "€";

            Id_Cabinet = db.CabinetRegister(Id_Angle, profondeur[0], largeur[0], price);
            Id_Command = db.CommandRegister(Id_Customer, Id_Cabinet);
            textBox13.Text += "\r\n";
            textBox13.Text += "\r\nThe ID of your command = " + Id_Command;  

            List<bool> stock_good = new List<bool>();
            m = 0;
            while (m != (n - 1))
            {
                string Id_Cleat = db.SearchID("Cleat", hauteur[m] - 4, 0, 0);
                string Id_BAPanel = db.SearchID("BA Panel", hauteur[m] - 4, 0, largeur[0], couleurPanneaux[m]);
                string Id_UDPanel = db.SearchID("UD Panel", 0, profondeur[0], largeur[0], couleurPanneaux[m]);
                string Id_BARail = db.SearchID("BA Rail", 0, 0, largeur[0]);
                string Id_FrRail = db.SearchID("Fr Rail", 0, 0, largeur[0]);
                string Id_LrRail = db.SearchID("Lr Rail", 0, profondeur[0], 0);
                db.BoxRegister(Id_Cabinet, hauteur[m], couleurPortes[m], coupelles[m], couleurPanneaux[m]);
                db.AddList(Id_Command, Id_Cleat, 4);
                db.AddList(Id_Command, Id_BAPanel, 1);
                db.AddList(Id_Command, Id_UDPanel, 2);
                db.AddList(Id_Command, Id_BARail, 2);
                db.AddList(Id_Command, Id_FrRail, 1);
                db.AddList(Id_Command, Id_LrRail, 4);
                stock_good.Add(db.StockVerify(Id_Cleat, 4));
                stock_good.Add(db.StockVerify(Id_BAPanel, 1));
                stock_good.Add(db.StockVerify(Id_UDPanel, 2));
                stock_good.Add(db.StockVerify(Id_BARail, 2));
                stock_good.Add(db.StockVerify(Id_FrRail, 1));
                stock_good.Add(db.StockVerify(Id_LrRail, 4));
                
                if (coupelles[m] == true)
                {
                    string Id_Cups = db.SearchID("Coupelles", 0, 0, 0);
                    db.AddList(Id_Command, Id_Cups, 2);
                    stock_good.Add(db.StockVerify(Id_Cups, 2));
                }
                if (couleurPortes[m] != "No door")
                {
                    string Id_Doors = db.SearchID("Door", hauteur[m] - 4, 0, largeur[0], couleurPortes[m]);
                    db.AddList(Id_Command, Id_Doors , 2);
                    stock_good.Add(db.StockVerify(Id_Doors, 2));
                }
                m++;
            }
            if ((n - 1) != 0)
            {
                db.AddList(Id_Command, Id_Angle, 4);
                stock_good.Add(db.StockVerify(Id_Angle, 4));
            }

            if (stock_good.Contains(false))
            {
                textBox13.Text += "\r\nMissing stock : a down payment is allowed (50% of the initial price).";
            }

            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select i.ID_Accessory, i.Quantity, c.Stock FROM List i JOIN Catalogue c ON i.ID_Accessory = c.ID_Accessory";
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView4.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
            textBox8.PasswordChar = '*';
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

                button7.Enabled = true;

                textBox7.Text = "";
                if (p < 7)
                {
                    button4.Enabled = true;
                    n++;
                    textBox6.Text = "Box" + n;
                    hauteur.Add(Convert.ToInt32(comboBox1.Text) + 4);
                    if (change == 1)
                    {
                        couleurPortes.Add("No door");
                        coupelles.Add(false);
                    }
                    
                    else
                    {
                        couleurPortes.Add(comboBox3.Text);
                        if (comboBox3.Text != "Glass")
                        {
                            coupelles.Add(true);
                        }
                        else
                        {
                            coupelles.Add(false);
                        }
                    }
                    couleurPanneaux.Add(comboBox5.Text);
                    p++;
                    if (p ==7)
                    {
                        textBox6.Text = "Limit reached";
                        button1.Enabled = false;
                    }
                }
                else
                {
                    textBox6.Text = "Limit reached";
                    button1.Enabled = false; // le rend non clickable
                }
            }
            else
            {
                textBox7.Text = "Incomplete fields !";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Recap;

            profondeur.Add(0);
            largeur.Add(0);

            Display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mettre portes dans un autre onglet car il nous faut la hauteur obtenue dans l'onglet box
            textBox7.Text = "";
            comboBox3.Enabled = true;
            string[] splitString = comboBox4.Text.Split(' ');
            FRrail frRail = new FRrail(Int32.Parse(splitString[0]));

            List<string> listDoor = new List<string> { };
            listDoor = db.Search("POR" + comboBox1.Text + frRail.width.ToString(), "Color", "Catalogue");  //boxHeight ou box.Height (attention au type) etc..
            comboBox3.Items.Clear();
            foreach (string i in listDoor)
            {
                comboBox3.Items.Add(i);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            n = 1;
            p = 0;
            corHeight = 0;
            textBox6.Visible = true;
            textBox6.Text = "Box " + n;
            button1.Enabled = true; // le rend clickable
            button1.Visible = true; // le rend visible 
            button7.Enabled = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox42.Visible = false;
            List<int> profondeur = new List<int>();
            List<int> largeur = new List<int>();
            List<int> hauteur = new List<int>();
            List<string> couleurPortes = new List<string>();
            List<string> couleurPanneaux = new List<string>();
            List<string> couleurCorniere = new List<string>();
            tabControl1.SelectedTab = Main;
            button4.Enabled = false;
            textBox7.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Box;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "0000")
            {
                tabControl1.SelectedTab = StoreKeeper;
                textBox7.Text = "";
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from Catalogue where (Stock - Stock_min - Nb_Pieces_Box) <= 0;";
                MySqlCommand commandDB = new MySqlCommand(query, myConn);
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
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    { 
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter the correct password !";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "0000")
            {
                textBox7.Text = "";
                tabControl1.SelectedTab = Seller;
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand commandDB = new MySqlCommand("select * from Command where Payed!='Closed' ;", myConn);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter the correct password !" ;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            tabControl1.SelectedTab = Base;
            List<string> listDepth = new List<string> { };
            listDepth = db.Search("TRG", "Depth", "Catalogue");
            foreach (string i in listDepth)
            {
                comboBox2.Items.Add(i);
            }
            List<string> listWidth = new List<string> {};
            List<string> listWidthPOR = new List<string> { };
            listWidth = db.Search("TRF", "Width", "Catalogue");

            listWidthPOR = db.Search("POR","Width","Catalogue");

            foreach (string i in listWidth)
            {
                if (listWidthPOR.Contains(i))
                {
                    comboBox4.Items.Add(i + " (Doors available)");
                }
                else
                { 
                    comboBox4.Items.Add(i);

                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0,1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from Command where Payed!='Closed'";
            if (textBox22.Text != "" | textBox23.Text != "" | textBox42.Text != "")
            {
                query += " AND ";
                if (textBox22.Text != "" & textBox23.Text == "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text != "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text == "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text != "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text == "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text != "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text != "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
            }
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
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

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox3.Enabled = false;
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            comboBox5.Items.Clear();
            checkBox1.Checked = false;
            if (comboBox2.Text != "" & comboBox4.Text != "")
            {
                LRrail lrRail = new LRrail(Int32.Parse(comboBox2.Text));
                string[] splitString = comboBox4.Text.Split(' ');
                FRrail frRail = new FRrail(Int32.Parse(splitString[0]));
                BArail baRail = new BArail(Int32.Parse(splitString[0]));

                textBox7.Text = "";

                List<string> listHeight = new List<string> {};
                listHeight = db.Search("TAS", "Height", "Catalogue");
                foreach (string i in listHeight)
                {
                    comboBox1.Items.Add(i);
                }

                List<string> listColor = new List<string> { };
                listColor = db.Search("PAH" + lrRail.depth.ToString() + frRail.width.ToString(), "Color", "Catalogue");  //boxDepth ou box.Depth (attention au type) etc..
                foreach (string i in listColor)
                {
                    comboBox5.Items.Add(i);
                }
                if (comboBox4.Text.Contains("(Doors available)"))
                {
                    checkBox1.Enabled = true;
                }
                if (!(comboBox4.Text.Contains("(Doors available)")))
                {
                    checkBox1.Enabled = false;
                }
                //Faire comboBox4.Text=splitString[0] bug parfois, donc je vide tout, j'ajoute l'élement 
                //purement int, et je prends l'élements 0 que je change en string. Et là ça bug plus
                comboBox4.Items.Clear();
                comboBox4.Items.Add(splitString[0]);
                comboBox4.Text = comboBox4.Items[0].ToString();
                largeur.Add(Int32.Parse(comboBox4.Text));
                profondeur.Add(Int32.Parse(comboBox2.Text));
                tabControl1.SelectedTab = Box;

                //Faut ajouter aussi fonction search ici pour que quand on clique sur le bouton
                //et qu'on passe à l'onglet Corniere, ça fait une recherche pour remplir le comboBox7
                //qui correspond à la couleur des cornières
            }
            else
            {
                textBox7.Text = "Incomplete fields !";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                textBox7.Text = "Enter a height to get the doors colors.";
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox8.Items.Clear();
            List<string> listCor = new List<string> { };
            //Trouver la hauteur totale à prendre pour notre armoire :
            List<string> listTotHeight = new List<string> { };
            listTotHeight = db.Search("COR", "Height", "Catalogue");

            int i = 0;
            corHeight = Int32.Parse(listTotHeight[0]); ;
            while (Int32.Parse(listTotHeight[i]) < hauteurtotale)
            {
                corHeight = Int32.Parse(listTotHeight[i]);
                i++;
            }
            listCor = db.Search("COR" + Convert.ToString(corHeight), "Color", "Catalogue");

            foreach (string j in listCor)
            {
                comboBox8.Items.Add(j);
            }


            tabControl1.SelectedTab = End;

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from Command where Payed!='Closed'";
            if (checkBox5.Checked == true)
            {
                try
                {
                    query += " AND ID_Command=  CONVERT(" + textBox10.Text + ",UNSIGNED INTEGER)";
                }
                catch
                {
                    textBox7.Text = "Error: Enter an integer";
                }
            }
            try
            {
                MySqlCommand commandDB = new MySqlCommand(query, myConn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            if (textBox10.Text != "")
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox10.Text + "--->" + comboBox6.Text;
                string instruction = "update Command d set d.Payed = \'" + comboBox6.Text + "\' where d.ID_Command= CONVERT(" + textBox10.Text + ",UNSIGNED INTEGER); SELECT * from Command where Payed!='Closed'";

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
                    textBox7.Text = "Invalid fields !";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter an ID_Command";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from Command where Payed!='Closed' AND Payed !='Unpayed'";
            if (textBox22.Text != "" | textBox23.Text != "" | textBox42.Text != "")
            {
                query += " AND ";
                if (textBox22.Text != "" & textBox23.Text == "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text != "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text == "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text != "" & textBox42.Text == "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text == "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text == "" & textBox23.Text != "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
                if (textBox22.Text != "" & textBox23.Text != "" & textBox42.Text != "")
                {
                    try
                    {
                        query += "ID_Cabinet = CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER) AND ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER) AND ID_Command = CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
            }
        
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
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
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                n = 1;
                p = 0;
                textBox6.Visible = true;
                textBox6.Text = "Box " + n;
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
                List<int> profondeur = new List<int>();
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

        private void button16_Click(object sender, EventArgs e)
        {
            if (comboBox8.Text != "")
            {
                tabControl1.SelectedTab = Register;
                couleurCorniere.Add(comboBox8.Text);
            }
            else
            {
                textBox7.Text = "Incomplete fields !";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox19.Text != "" & textBox20.Text != "" & textBox21.Text != "")
            {
                finished = true;
                tabControl1.SelectedTab = CommandDetail;
                Id_Customer = db.CustomerRegister(textBox19.Text, textBox20.Text, textBox21.Text);
                Id_Angle = db.SearchAngle(corHeight, couleurCorniere[0]);
                Display13();
  
            }
            else
            {
                textBox7.Text = "Incomplete fields !";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from Box ";
            if (textBox22.Text != "" | textBox6.Text != "" & textBox42.Text != "")
            {
                try
                {
                    query += "where ID_Cabinet =  CONVERT(" + textBox22.Text + ",UNSIGNED INTEGER)";
                }
                catch
                {
                    textBox7.Text = "Error: Enter an integer";
                }
            }
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
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

        private void button19_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from Customer ";
            if (textBox23.Text != "" | textBox24.Text !="")
            {
                query += "where ";
                if (textBox23.Text != "" & textBox24.Text=="")
                { 
                    try
                    {
                        query += "ID_Customer =  CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER)";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter an integer";
                    }
                }
                if (textBox23.Text == "" & textBox24.Text != "")
                {
                    query += "Name = '" + textBox24.Text + "'";
                }
                if (textBox23.Text != "" & textBox24.Text != "")
                {
                    try
                    {
                        query += "ID_Customer = CONVERT(" + textBox23.Text + ",UNSIGNED INTEGER) AND Name='"+textBox24.Text+"'";
                    }
                    catch
                    {
                        textBox7.Text = "Error: Enter valid fields";
                    }
                }
            }
            MySqlCommand commandDB = new MySqlCommand(query, myConn); 
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
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox22.Visible = !(textBox22.Visible);
            textBox22.Text = "";
            textBox7.Text = "";
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "Load a table.";
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox23.Visible = !(textBox23.Visible);
            textBox23.Text = "";
            textBox7.Text = "";
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "Load a table.";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            button11.Enabled = true;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "Load Customer table.";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox24.Visible = !(textBox24.Visible);
            textBox24.Text = "";
            textBox7.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"command1.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"ticket.txt");

            writer.Write(textBox13.Text);
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"proof.txt");
            writer.WriteLine("--------------PROOF OF THE PAYEMENT--------------------------------");
            writer.WriteLine(" ID_Command \t| ID_Customer \t|  ID_Cabinet \t|  Payed \t|");
            writer.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView2.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox7.Text = "Enter an ID_Command and reload the table.";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "0000")
            {
                textBox7.Text = "";
                tabControl1.SelectedTab = Secretary;
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand commandDB = new MySqlCommand("select * from Catalogue ;", myConn);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter the correct password !";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand("select * from Catalogue ;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand("select * from Suppliers ;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox31.Text != "" & textBox32.Text != "")
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox31.Text + "--->" + textBox32.Text;
                string instruction = "update Catalogue d set d.Price = \'" + textBox32.Text + "\' where d.ID_Accessory= '" + textBox10.Text + "'; SELECT * from Catalogue d";

                MySqlCommand commandDB = new MySqlCommand(instruction, myConn);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = commandDB;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbdataset);
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    textBox7.Text = "Invalid fields !";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter an ID_Command and a new Price";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox31.Text != "" & textBox33.Text != "")
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox31.Text + "--->" + textBox33.Text;
                string instruction = "update Catalogue d set d.ID_Supplier = '" + textBox33.Text + "' where d.ID_Accessory= '" + textBox31.Text + "'; SELECT * from Catalogue d";

                MySqlCommand commandDB = new MySqlCommand(instruction, myConn);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = commandDB;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbdataset);
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    textBox7.Text = "Invalid fields !";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter an ID_Command and a new ID_Supplier";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox31.Text != "" & textBox36.Text != "" & textBox41.Text != "")
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox31.Text + "--->" + textBox36.Text;
                string instruction = "update Suppliers d set d.Price_Supplier= '" + textBox36.Text + "' where d.ID_Accessory= '" + textBox31.Text + "' and d.ID_Supplier ='"+ textBox41.Text + "'; SELECT * from Suppliers d";

                MySqlCommand commandDB = new MySqlCommand(instruction, myConn);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = commandDB;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbdataset);
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    textBox7.Text = "Invalid fields !";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter an ID_Command, the specifid ID_Supplier and a new Price_Supplier";
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox31.Text != "" & textBox37.Text != "" & textBox41.Text !="")
            {
                string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                textBox7.Text = textBox31.Text + "--->" + textBox37.Text;
                string instruction = "update Suppliers d set d.Delay= '" + textBox37.Text + "' where d.ID_Accessory= '" + textBox31.Text + "' and d.ID_Supplier ='" + textBox41.Text + "'; SELECT * from Suppliers d";

                MySqlCommand commandDB = new MySqlCommand(instruction, myConn);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = commandDB;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbdataset);
                    textBox7.Text = "";

                }
                catch (Exception ex)
                {
                    textBox7.Text = "Invalid fields !";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox7.Text = "Enter an ID_Command, the specific ID_Supplier and a new Delay";
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select * from List ";
            if (textBox42.Text != "")
            {
                try
                {
                    query += "where ID_Command =  CONVERT(" + textBox42.Text + ",UNSIGNED INTEGER)";
                }
                catch
                {
                    textBox7.Text = "Error: Enter an integer";
                }
            }
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
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

        private void button30_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"command2.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox42.Visible = !(textBox42.Visible);
            textBox42.Text = "";
            textBox7.Text = "";
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "Load Customer table.";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"listComponents.txt");
            writer.WriteLine("--------------PROOF OF THE PAYEMENT--------------------------------");
            writer.WriteLine(" ID_Command \t| ID_Customer \t|  ID_Cabinet \t|  Payed \t|");
            writer.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView4.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query = "select i.ID_Accessory, i.Quantity, c.Stock FROM List i JOIN Catalogue c ON i.ID_Accessory = c.ID_Accessory";
            MySqlCommand commandDB = new MySqlCommand(query, myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView4.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
