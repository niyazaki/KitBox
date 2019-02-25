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
        int price;
    }

    class Box
    {

        string color;
        int height;
        bool hasDoor;
        int price;

        List<Panel> panels;
        List<Rail> rails;
        List<Door> doors;

        public Box(string color, int height, bool hasDoor)
        {
            this.color = color;
            this.height = height;
            this.hasDoor = hasDoor;

            if (!this.hasDoor)
            {
                
            }
        }

        public void SetPrice()
        {

        }
    }

    abstract class Rail
    {
        abstract double price;


    }

    class LRrail : Rail
    {
        string code;
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

    abstract class Panel
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

    class Door
    {
        double price;
        string color;
        bool cup;
        string code;

        public Door(double price, string color, bool cup, string code)
        {
            this.price = price;
            this.color = color;
            this.cup = cup;
            this.code = code;
        }
    }

    class Cleat
    {
        string code;
        double price;
        int[] height = { 32, 42, 52 };
    }

    class Angle
    {

    }
}
