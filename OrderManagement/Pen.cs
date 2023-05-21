using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace OrderManagement
{
    class Pen : Stationery
    {

        public int PenPrice = 2;

        public Pen(int numberOfBluePens, int numberOfBlackPens, int numberOfRedPens)
        {
            StationeryType = "Pen";
            base.Price = PenPrice;
            AdditionalCharge = 1;
            base.NumberOfBlueItems = numberOfBluePens;
            base.NumberOfBlackItems = numberOfBlackPens;
            base.NumberOfRedItems =  numberOfRedPens;
        }

        public override int Total()
        {
            return BluePensTotal() + BlackPensTotal() + RedPensTotal();
        }

        public int BluePensTotal()
        {
            return (base.NumberOfBlueItems * Price);
        }
        public int BlackPensTotal()
        {
            return (base.NumberOfBlackItems * Price);
        }
        public int RedPensTotal()
        {
            return (base.NumberOfRedItems * Price);
        }
    }
}
