using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class InvoiceReport : Order
    {
        public int tableWidth = 75;
        public InvoiceReport(string customerName, string customerAddress, string orderDueDate, List<Stationary> stationary)
        {
            base.CustomerName = customerName;
            base.CustomerAddress = customerAddress;
            base.OrderDueDate = orderDueDate;
            base.OrderedItems = stationary;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
            OrderMarkerDetails();
            OrderPenDetails();
            OrderPencilDetails();
            BlueColorItemSurcharge();
        }

        public void BlueColorItemSurcharge()
        {
            Console.WriteLine("Blue color item Surcharge       " + TotalAmountOfBlueItems() + " @ $" + base.OrderedItems[0].AdditionalCharge + " Producer Price Index = $" + TotalPriceBlueColorItemSurcharge());
        }

        public int TotalAmountOfBlueItems()
        {
            return base.OrderedItems[0].NumberOfBlueItems + base.OrderedItems[1].NumberOfBlueItems +
                   base.OrderedItems[2].NumberOfBlueItems;
        }

        public int TotalPriceBlueColorItemSurcharge()
        {
            return TotalAmountOfBlueItems() * base.OrderedItems[0].AdditionalCharge;
        }
        public void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Blue   ", "  Black  ", " Red ");
            PrintLine();
            PrintRow("Marker", 
                base.OrderedItems[0].NumberOfBlueItems.ToString(), 
                base.OrderedItems[0].NumberOfBlackItems.ToString(), 
                base.OrderedItems[0].NumberOfRedItems.ToString());
            PrintRow("Pen", 
                base.OrderedItems[1].NumberOfBlueItems.ToString(), 
                base.OrderedItems[1].NumberOfBlackItems.ToString(), 
                base.OrderedItems[1].NumberOfRedItems.ToString());
            PrintRow("Pencil", 
                base.OrderedItems[2].NumberOfBlueItems.ToString(), 
                base.OrderedItems[2].NumberOfBlackItems.ToString(), 
                base.OrderedItems[2].NumberOfRedItems.ToString());
            PrintLine();
        }
        public void OrderMarkerDetails()
        {
            Console.WriteLine("\nMarkers 		  " + 
                base.OrderedItems[0].TotalQuantityOfItems() + " @ $" + 
                base.OrderedItems[0].Price + " Producer Price Index = $" + 
                base.OrderedItems[0].Total());
        }
        public void OrderPenDetails()
        {
            Console.WriteLine("Pens 		  " + 
                base.OrderedItems[1].TotalQuantityOfItems() + " @ $" + 
                base.OrderedItems[1].Price + " Producer Price Index = $" + 
                base.OrderedItems[1].Total());
        }
        public void OrderPencilDetails()
        {
            Console.WriteLine("Pencils 		  " + 
                base.OrderedItems[2].TotalQuantityOfItems() + " @ $" + 
                base.OrderedItems[2].Price + " Producer Price Index = $" + 
                base.OrderedItems[2].Total());
        }
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
