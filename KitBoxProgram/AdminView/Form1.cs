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
            string myConnectionString = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;"+ "OldGuids=True;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
               connection.Open(); //The exception is thrown HERE

            }
            catch (MySqlException ex)
            {
                String error = ex.Message;
                
            }
        }
    }
}
