using OrderManagement;
using System;
using System.Collections.Generic;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var (customerName, customerAddress, orderDueDate) = CustomerDetailInput();

            var orderedItems = CustomerOrderInput();

            InvoiceReport(customerName, customerAddress, orderDueDate, orderedItems);

            StationaryReport(customerName, customerAddress, orderDueDate, orderedItems);

            ColorReport(customerName, customerAddress, orderDueDate, orderedItems);
        }

        public static Marker OrderMarkerInput()
        {
            Console.Write("\nPlease enter the number of Blue Markers: ");
            int blueMarker = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Black Markers: ");
            int blackMarker = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Red Markers: ");
            int redMarker = Convert.ToInt32(customerInput());

            Marker marker = new Marker(blueMarker, blackMarker, redMarker);
            return marker;
        }

        public static Pen OrderPenInput()
        {
            Console.Write("\nPlease enter the number of Blue Pens: ");
            int bluePen = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Black Pens: ");
            int blackPen = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Red Pens: ");
            int redPen = Convert.ToInt32(customerInput());

            Pen pen = new Pen(bluePen, blackPen, redPen);
            return pen;
        }

        public static Pencil OrderPencilInput()
        {
            Console.Write("\nPlease enter the number of Blue Pencil: ");
            int bluePencil = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Black Pencil: ");
            int blackPencil = Convert.ToInt32(customerInput());
            Console.Write("Please enter the number of Red Pencil: ");
            int redPencil = Convert.ToInt32(customerInput());

            Pencil pencil = new Pencil(bluePencil, blackPencil, redPencil);
            return pencil;
        }

        public static string customerInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();

            }
            return input;
        }

        private static void ColorReport(string customerName, string customerAddress, string orderDueDate, List<Stationary> orderedStationary)
        {
            ColorReport colorReport = new ColorReport(customerName, customerAddress, orderDueDate, orderedStationary);
            colorReport.GenerateReport();
        }

        private static void StationaryReport(string customerName, string customerAddress, string orderDueDate, List<Stationary> orderedStationary)
        {
            StationaryReport stationaryReport = new StationaryReport(customerName, customerAddress, orderDueDate, orderedStationary);
            stationaryReport.GenerateReport();
        }

        private static void InvoiceReport(string customerName, string customerAddress, string orderDueDate, List<Stationary> orderedStationary)
        {
            InvoiceReport invoiceReport = new InvoiceReport(customerName, customerAddress, orderDueDate, orderedStationary);
            invoiceReport.GenerateReport();
        }

        private static (string customerName, string customerAddress, string orderDueDate) CustomerDetailInput()
        {
            Console.Write("Please enter your Name: ");
            string customerName = customerInput();
            Console.Write("Please enter your Address: ");
            string customerAddress = customerInput();
            Console.Write("Please enter your Due Date: ");
            string orderDueDate = customerInput();
            return (customerName, customerAddress, orderDueDate);
        }

        private static List<Stationary> CustomerOrderInput()
        {
            Marker marker = OrderMarkerInput();
            Pen pen = OrderPenInput();
            Pencil pencil = OrderPencilInput();

            var orderedItems = new List<Stationary>();
            orderedItems.Add(marker);
            orderedItems.Add(pen);
            orderedItems.Add(pencil);
            return orderedItems;
        }
    }
}
