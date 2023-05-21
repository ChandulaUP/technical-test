using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class StationeryReport : Order
    {

        public int tableWidth = 20;
        public StationeryReport(string customerName, string customerAddress, string orderDueDate, List<Stationery> stationery)
        {
            base.CustomerName = customerName;
            base.CustomerAddress = customerAddress;
            base.OrderDueDate = orderDueDate;
            base.OrderedItems = stationery;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour stationery report has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        }

        public void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            PrintRow("Marker", base.OrderedItems[0].TotalQuantityOfItems().ToString());
            PrintRow("Pen", base.OrderedItems[1].TotalQuantityOfItems().ToString());
            PrintRow("Pencil", base.OrderedItems[2].TotalQuantityOfItems().ToString());
            PrintLine();
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
