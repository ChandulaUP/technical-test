using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace OrderManagement
{
    class Pencil : Stationary
    {
        public int PencilPrice = 1;

        public Pencil(int numberOfBluePencils, int numberOfBlackPencils, int numberOfRedPencils)
        {
            StationaryType = "Pencil";
            base.Price = PencilPrice;
            AdditionalCharge = 1;
            base.NumberOfBlueItems = numberOfBluePencils;
            base.NumberOfBlackItems = numberOfBlackPencils;
            base.NumberOfRedItems = numberOfRedPencils;
        }

        public override int Total()
        {
            return BluePencilsTotal() + BlackPencilsTotal() + RedPencilsTotal();
        }

        public int BluePencilsTotal()
        {
            return (base.NumberOfBlueItems * Price);
        }
        public int BlackPencilsTotal()
        {
            return (base.NumberOfBlackItems * Price);
        }
        public int RedPencilsTotal()
        {
            return (base.NumberOfRedItems * Price);
        }

    }
}
