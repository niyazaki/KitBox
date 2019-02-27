using System.Data.SQLite;
using System.IO;

namespace SQLiteDemo
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source= Db.db");
        //This part is useless because we don't want to create a new DB
//            if (!File.Exists("./catalogue.db"))
//            {
//                SQLiteConnection.CreateFile("catalogue.db");
//                System.Console.WriteLine("Database file created");
//            }
        }
        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
