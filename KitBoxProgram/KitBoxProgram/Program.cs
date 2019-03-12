using System;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          MySqlConnection connection = new MySqlConnection("database = kitbox ; server = db4free.net; user id = kitbox; pwd =ecamgroupe4");

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

          //If we wanna add an item to the db (must be done in a method);
          /*

          MySqlCommand cmd = new MySqlCommand("INSERT into nomdelatable(colonne concernée 1, colonne concernée 2,...) VALUES(@parametre1 ex:nom colonne1, @parametre2)", connection)
          cmd.Parameters.AddWithValue("@parametre1", valeur1);
          cmd.Parameters.AddWithValue("@parametre2", valeur2);
          cmd.ExecuteNonQuery();
          cmd.Parameters.Clear();

          */

        }
    }
}
