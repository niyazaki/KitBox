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
using System.Windows.Forms;

namespace AdminView
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

                string coStr = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
                MySqlConnection myConn = new MySqlConnection(coStr);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand(" select * database.edata ;",myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                MessageBox.Show("Connected");
                myConn.Close();
                button1.Visible = false;
                button2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myConnection = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDB = new MySqlCommand(" select * from Command ;", myConn);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
