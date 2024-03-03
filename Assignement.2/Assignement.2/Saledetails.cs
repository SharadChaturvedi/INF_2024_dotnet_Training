using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price
Pass the other information like SalesNo, Productno, Price,Qty and Dateof sale through constructor
call the show data method to display the values.*/

namespace Assignement._2
{
    internal class Saledetails
    {
        // Data members/fields
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public DateTime DateOfSale;
        public int Qty;
        public double TotalAmount;

        // Constructor
        public Saledetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            DateOfSale = dateOfSale;
            Qty = qty;
            UpdateTotalAmount(); // Call method to update TotalAmount
        }

        // Method to update TotalAmount
        private void UpdateTotalAmount()
        {
            TotalAmount = Qty * Price;
        }

        // Method to display data
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Date of Sale: " + DateOfSale.ToShortDateString());
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Enter Sales No:");
            int salesNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product No:");
            int productNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Date of Sale (yyyy-MM-dd):");
            DateTime dateOfSale = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            int qty = Convert.ToInt32(Console.ReadLine());

            // Create an instance of Saledetails
            Saledetails sale = new Saledetails(salesNo, productNo, price, dateOfSale, qty);

            // Display sale details
            sale.ShowData();
            Console.ReadLine();
        }
    }

}



