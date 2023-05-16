using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace OrderManagement
{
    class Marker : Stationary
    {
        public int markerPrice = 3;
        public Marker(int blue, int black, int red)
        {
            StationaryType = "Marker";
            base.Price = markerPrice;
            AdditionalCharge = 1;
            base.NumberOfBlueItems = blue;
            base.NumberOfBlackItems = black;
            base.NumberOfRedItems = red;
        }
        public override int Total()
        {
            return BlueMarkersTotal() + BlackMarkersTotal() + RedMarkersTotal();
        }

        public int BlueMarkersTotal()
        {
            return (base.NumberOfBlueItems * Price);
        }
        public int BlackMarkersTotal()
        {
            return (base.NumberOfBlackItems * Price);
        }
        public int RedMarkersTotal()
        {
            return (base.NumberOfRedItems * Price);
        }
    }
}
