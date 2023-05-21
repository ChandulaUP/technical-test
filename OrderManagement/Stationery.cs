using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    abstract class Stationery
    {
        public string StationeryType { get; set; }
        public int Price { get; set; }
        public int AdditionalCharge { get; set; }
        public int NumberOfBlueItems { get; set; }
        public int NumberOfBlackItems { get; set; }
        public int NumberOfRedItems { get; set; }
        
        public int TotalQuantityOfItems()
        {
            return NumberOfBlueItems + NumberOfBlackItems + NumberOfRedItems;
        }

        public int AdditionalChargeTotal()
        {
            return NumberOfBlueItems * AdditionalCharge;
        }
        public abstract int Total();

    }
}
