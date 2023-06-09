﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class ColorReport : Order
    {
        public int tableWidth = 75;
        public ColorReport(string customerName, string customerAddress, string orderDueDate, List<Stationery> stationery)
        {
            base.CustomerName = customerName;
            base.CustomerAddress = customerAddress;
            base.OrderDueDate = orderDueDate;
            base.OrderedItems = stationery;
        }
        public override void GenerateReport()
        {
            Console.WriteLine("\nYour color report has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        }

        public void generateTable()
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
