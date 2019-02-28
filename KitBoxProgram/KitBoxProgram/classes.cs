using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxProgram
{
    class Cabinet
    {
        List<Box> boxes;
        double price;

        public double GetPrice()
        {
            return price;
        }
    }

    class Box
    {
        string color;
        int height;
        bool hasDoor;
        double price;

        List<Accessory> accessories;

        public Box(string color, int height, bool hasDoor)
        {
            this.color = color;
            this.height = height;
            this.hasDoor = hasDoor;

            if (!this.hasDoor)
            {
                
            }
        }

        public void AddAccessory(Accessory accessory)
        {

        }

        public void SetPrice()
        {

        }

        public double GetPrice()
        {
            return price;
        }
    }

    abstract class Accessory
    {
        public double price;
        public string code;

        public double GetPrice()
        {
            return price;
        }

        public string GetCode()
        {
            return code;
        }
    }

    abstract class Rail : Accessory
    {

    }

    class LRrail : Rail
    {
        double price;
        int slot;
        int[] depth = { 32, 42, 52, 62 };
    }

    class Frail : Rail
    {
        
    }

    class Brail : Rail
    {

    }

    abstract class Panel : Accessory
    {
        string color;
    }

    class UDPanel : Panel
    {

    }

    class LRpanel : Panel
    {
    }

    class BApanel : Panel
    {
    }

    class Door : Accessory
    {
        string color;
        bool cup;

        public Door(double price, string color, bool cup, string code)
        {
            this.price = price;
            this.color = color;
            this.cup = cup;
            this.code = code;
        }
    }

    class Cleat : Accessory
    {
        int height;

    }

    class Angle : Accessory
    {
        int height;
        string color;
    }
}
