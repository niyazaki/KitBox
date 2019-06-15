using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KitBoxProgram
{
    class DB
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DB()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "db4free.net";
            database = "kitbox";
            uid = "kitbox";
            password = "ecamgroupe4";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                  database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "OldGuids=True;";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenCo()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseCo()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void InsertCatalogue(string idacc, string reference, int height, int depth, int width, string color, int price, int nb, int idsupp)
        {
            string values = String.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", idacc, reference, height, depth, width, color, price, nb, idsupp);
            string query = "INSERT INTO Catalogue (ID-Accessory, Ref, Height, Depth, Width, Color, Price, Nb-Pieces/Box, Id-Supplier) VALUES(" + values + ")";

            //open connection
            if (this.OpenCo() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseCo();
            }
        }

        //Update statement
        public void UpdateSuppPrice()
        {
            //WIP, have to update the query
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenCo() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseCo();
            }
        }

        //Delete statement
        public void Delete()
        {
            //WIP, have to update the query
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenCo() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseCo();
            }
        }
        //Select statement
        public List<string> Search(string code, string column, string table)
        {
            string query = "SELECT DISTINCT " + column + " FROM " + table + " d WHERE d.ID_Accessory LIKE '" + code + "%' order by d."+column;

            //Create a list to store the result
            List<string> res = new List<string>();
            //Open connection
            if (this.OpenCo() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    res.Add(dataReader.GetString(0));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseCo();

                //return list to be displayed
                return res;
            }
            else
            {
                return res;
            }
        }
        public string SearchPrice(string reff, int height, int depth, int width, string color="")
        {
            string query = "SELECT Price FROM Catalogue d WHERE d.Ref ='" + reff+ "' and d.Height="+height+" and d.Depth="+depth+ " and d.Width=" + width;
            if (color!="")
            {
                query += " and d.Color='" + color+"'";
            }
            string price = "0" ;
            if (this.OpenCo() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        price = dataReader.GetString(0);
                    }
                    dataReader.Close();
                    this.CloseCo();
                    return price;
                }
                catch
                {
                    return price;
                }
            }
            else
            {
                return price;
            }
        }
        public string CustomerRegister(string name, string email, string adress)
        {
            string query = "INSERT INTO Customer(Name, E_mail, Adress) VALUES ('" + name + "', '"+email+"', '"+adress+"')";
            string secondQuery = "SELECT ID_Customer FROM Customer where Name='"+name+"' AND E_mail='"+email+"' AND Adress='"+adress+"' LIMIT 1";
            string res = "";
            if (this.OpenCo() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                MySqlCommand secondCmd = new MySqlCommand(secondQuery, connection);
                MySqlDataReader dataReader = secondCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    res = dataReader.GetString(0);
                }
                dataReader.Close();
                this.CloseCo();
            }
            return res;
        }
        public string SearchAngle(int height, string color)
        {
            string query = "SELECT ID_Accessory FROM Catalogue where Height='" + height + "' AND Color='" + color +"' LIMIT 1";
            string id_angle = "";
            if (this.OpenCo() == true)
            {
                MySqlCommand secondCmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = secondCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    id_angle = dataReader.GetString(0);
                }
                dataReader.Close();
                this.CloseCo();
            }
            return id_angle;
        }
    }
    class Cabinet
    {
        int width;
        int depth;
        int height;
        Angle angle;
        private List<Box> boxes;
        double price;

        public Cabinet(int width, int depth, List<Box> boxes, Angle angle)
        {
            this.width = width;
            this.depth = depth;
            this.boxes = boxes;
            this.angle = angle;
        }

        public double GetPrice()
        {
            price = angle.price * angle.nbPiece;
            foreach (Box i in boxes)
            {
                price += i.price;
            }
            return price;
        }

        public int GetHeight()
        {
            height = 0;
            foreach (Box i in boxes)
            {
                height += i.height;
            }
            return height;
        }

        public void AddBox(Box box)
        {
            boxes.Add(box);
        }
    }

    class Box
    {
        string color;
        public int height;
        bool hasDoor;
        public double price;

        List<Accessory> accessories;

        public Box(string color, int height)
        {
            this.color = color;
            this.height = height;
        }

        public void AddAccessory(Accessory accessory)
        {
            accessories.Add(accessory);
        }

        public double GetPrice()
        {
            price = 0;
            foreach (Accessory i in accessories)
            {
                price += i.price * i.nbPiece;
            }
            return price;
        }
    }

    abstract class Accessory
    {
        public DB db = new DB();

        public double price;
        public string code;
        int stock;
        public int nbPiece;

        public double GetPrice()
        {
            price =  db.Search(code, "Price", "Catalogue").ConvertAll(double.Parse)[0];
            return price;
        }

        public string GetCode()
        {
            return code;
        }

        public int GetNbPiece()
        {
            nbPiece = db.Search(code, "Nb-Pieces/Box", "Catalogue").ConvertAll(int.Parse)[0];
            return nbPiece;
        }

        public int GetStock()
        {
            return stock;
        }
    }

    abstract class Rail : Accessory
    {

        public string GetCode(string dimension)
        {
            return code + dimension;
        }
    }

    class LRrail : Rail
    {
        public int depth;

        public LRrail(int depth)
        {
            this.depth = depth;
            code = "TRG";
        }

        public int GetDepth()
        {
            return depth;
        }
    }

    class FRrail : Rail
    {
        public int width;

        public FRrail(int width)
        {
            this.width = width;
            code = "TRF";
        }

        public int GetWidth()
        {
            return width;
        }
    }

    class BArail : Rail
    {
        public int width;

        public BArail(int width)
        {
            this.width = width;
            code = "TRR";
        }

        public int GetWidth()
        {
            return width;
        }
    }

    abstract class Panel : Accessory
    {
        private string color;

        public Panel(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }
    }

    class UDpanel : Panel
    {
        private int width;
        private int depth;

        public UDpanel(string color, int width, int depth) : base(color)
        {
            this.width = width;
            this.depth = depth;
            code = "PAH";
        }
        public string GetCode(string depth, string width, string color)
        {
            return code + depth + width + color;
        }
    }

    class LRpanel : Panel
    {
        private int depth;
        private int height;

        public LRpanel(string color, int depth, int height) : base(color)
        {
            this.depth = depth;
            this.height = height;
            code = "PAG";
        }
        public string GetCode(string height, string depth, string color)
        {
            return code + height + depth + color;
        }
    }

    class BApanel : Panel
    {
        private int width;
        private int height;

        public BApanel(string color, int width, int height) : base(color)
        {
            this.width = width;
            this.height = height;
            code = "PAR";
        }

        public string GetCode(string height, string width, string color)
        {
            return code + height + width + color;
        }
    }

    class Cleat : Accessory
    {
        public int height;

        public Cleat(int height)
        {
            this.height = height;
            code = "TAS";
        }

        public string GetCode(string height)
        {
            return code + height;
        }
    }

    class Door : Accessory
    {
        string color;
        bool cup;

        public Door(string color, bool cup)
        {
            this.color = color;
            this.cup = cup;
            code = "POR";
        }
        public string GetCode(string height, string width, string color)
        {
            return code + height + width + color;
        }
    }

    class Angle : Accessory
    {
        int height;
        string color;

        public Angle(int height, string color)
        {
            this.height = height;
            this.color = color;
            code = "COR";
        }

        public string GetCode(string heightTot, string color)
        {
            return code + heightTot + color;
        }
    }
}