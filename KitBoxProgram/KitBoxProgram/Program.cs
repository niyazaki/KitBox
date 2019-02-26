using System;
using System.Data.SQLite;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databaseObject = new Database();

            /**
             * INSERT INTO DB
             **
            
            string qwery = "INSERT INTO table ('id1','id2') VALUES (@id1,@id2)"; //Par ex table album avec titre(id1), artiste(id2)
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.myConnection.Open();
            myCommand.Parameters.AddWhitValues("@id1", "MetsCeQueTuVeux"); //@titre, ex: Halo
            myCommand.Parameters.AddWhitValues("@id2", "MetsCeQueTuVeux"); //@artiste, ex: Beyoncé
            var result = myCommand.ExecuteNonQuery();
            databaseObject.myConnection.Close();

            Console.WriteLine("Rows Added: {0}", result); //Dis qu'un élément vient d'être ajouté à la DB. Ainsi t'ajoute  un par un les élem dans ta table
            */



            /**
             * SELECT FROM DB
             **
            
            string qwery = "SELECT * FROM table";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.myConnection.Open();
            myCommand.Parameters.AddWhitValues("@id1", "MetsCeQueTuVeux"); //@titre, ex: Halo
            myCommand.Parameters.AddWhitValues("@id2", "MetsCeQueTuVeux"); //@artiste, ex: Beyoncé
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine("table : {0} - id2 : {1}", result["id2"], result["id1"]); //Si on run, on verra avec l'ex du dessus: Album : Halo - Artiste: Beyoncé et chaque nouvelle ligne correspond à une musique et son artiste
                }
            }
            databaseObject.myConnection.Close();
    */

            Console.ReadKey();

        }
    }
}
