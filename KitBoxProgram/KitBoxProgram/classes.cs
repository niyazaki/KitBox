using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KitBoxProgram
{
    class Database
    {
      public MySqlConnection connection;

      public Database()
      {
        connection = new MySqlConnection("database = kitbox; server = db4free.net; user id = kitbox; pwd =ecamgroupe4");
      }

      public void OpenCo()
      {
        try
        {
          connection.Open();

          //Show message to say that it's connected
          MessageBox.Show("Connected");
        }

        catch (MySqlException e)
        {
          MessageBox.Show(e.ToString());
          MessageBox.Show("Connexion failed !");
        }
      }

      public void AddtoDb()
      {
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
    class Cabinet
    {
        int width;
        int depth;
        int height;
        Accessory.Angle angle;
        private List<Box> boxes;
        double price;

        public Cabinet(int width, int depth, List<Box> boxes, Accessory.Angle angle)
        {
            this.width = width;
            this.depth = depth;
            this.boxes = boxes;
            this.angle = angle;
        }

        public double GetPrice()
        {
            price = 0;
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

        public Box(string color, int height, bool hasDoor)
        {
            this.color = color;
            this.height = height;
            this.hasDoor = hasDoor;
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
                price += i.price;
            }
            return price;
        }
    }

    public abstract class Accessory
    {
        public double price;
        public string code;
        int stock;

        public double GetPrices(MySqlConnection connection, string reference, double height, double width, double depth, string color)
        {
            string dbColor = GetColorDB(color);

            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT Price, PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + reference + "'AND height='" + Convert.ToString(height) + "'AND width='" + Convert.ToString(width) + "'AND depth='" + Convert.ToString(depth) + "'AND color='" + dbColor + "'", connection);

            reader = command.ExecuteReader();

            double price = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    price = reader.GetDouble(0) * reader.GetDouble(1);
                }
            }
            else
            {
                MessageBox.Show("there is no rows in the datareader prices");
            }

            reader.Close();

            public string GetCode()
            {
                return code;
            }

            public int GetStock()
            {
                return stock;
            }
        }

        abstract class Rail : Accessory
        {

        }

        class LRrail : Rail
        {
            int depth;

            public LRrail(int depth)
            {
                this.depth = depth;
            }

            public int GetDepth()
            {
                return depth;
            }
        }

        class FRrail : Rail
        {
            int width;

            public FRrail(int width)
            {
                this.width = width;
            }

            public int GetWidth()
            {
                return width;
            }
        }

        class BArail : Rail
        {
            int width;

            public BArail(int width)
            {
                this.width = width;
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
            }
        }

        public class Cleat : Accessory
        {
            private int height;

            public Cleat(int height)
            {
                this.height = height;
            }
        }

        public class Angle : Accessory
        {
            int height;
            string color;

            public Angle(int height, string color)
            {
                this.height = height;
                this.color = color;
            }
        }
    }

