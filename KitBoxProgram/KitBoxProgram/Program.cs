using System;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          MySqlConnection connection = new MySqlConnection("database = //insert db name ; server = localhost; user id = root; pwd =");

          try
          {
            connection.Open();

            //Show message to say that it's connected
            MessageBox.Show("Connected");
          }

          catch (MySqlException e)
          {
            Message.Show(e.ToString());
            Message.Show("Connexion failed !");
          }
        }
    }
}
