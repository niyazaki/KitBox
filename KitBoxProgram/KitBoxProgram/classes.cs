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
    public class Database
    {
        public MySqlConnection connection;
        public string coStr = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";
        public Database()
        {
            connection = new MySqlConnection(coStr);
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
        public void CloseCo(){
          connection.Close();
        }

    }

    class SearchClass
    {
        public MySqlConnection connection;
        public string coStr = "SERVER=db4free.net;" + "DATABASE=kitbox;" + "UID=kitbox;" + "PASSWORD=ecamgroupe4;" + "OldGuids=True;";

        public List<string> Search(string code, string column, string table)
        {

            List<string> res = new List<string>();
            connection = new MySqlConnection(coStr);
            MySqlDataReader mdr;

            string query = "SELECT DISTINCT" + column + " FROM " + table + " WHERE ID accessory LIKE'" + code + "%'";

            MySqlCommand command = new MySqlCommand(query, connection);
            mdr = command.ExecuteReader();
            try
            {
                while (mdr.Read())
                {
                    res.Add(mdr.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Error while reading");
            }
            return res;
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
            price = angle.price;
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
                price += i.price;
            }
            return price;
        }
    }

    abstract class Accessory
    {
        public double price;
        public string code;
        int stock;

        public double GetPrice()
        {
            return price;
        }

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

        public string GetCode(string dimension)
        {
            return code + dimension;
        }
    }

    class LRrail : Rail
    {
        int depth;

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
        int width;

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
        int width;

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
        private int height;

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
