using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxProgram
{
    class Locker
    {
    }

    abstract class Rail
    {
    }
    class RailLR : Rail
    {
      int price;
      int lenght;
      int slot;
      string code;
    }
    class RailFR : Rail
    {
    }
    class RailBA : Rail
    {
    }

    abstract class Panel
    {
    }
    class PanelUD : Panel
    {
    }
    class PanelLR : Panel
    {
    }
    class PanelBA : Panel
    {
    }

    class Cabinet
    {
    }
    class Door
    {
      int price;
      string color;
      bool cup;
    }
    class Cleat
    {
    }
    class Angle
    {
    }


}
