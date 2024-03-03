using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*Create a class called Customer with Customerid, Name, Age, Phone,City
 * .Write a constructor with no arguments and another constructor with all information.  
 * Write a method called DisplayCustomer(), which is called directly without any object. Also  include destructor */

namespace Assignement._2
{
    internal class Customer
    {
        //  data members 
        public double Customerid;
        public string Name;
        public string Address;
        public double Age;
        public double Phonenum;
        public string City;

        //constructor with no arguments 
        //givig default values 

        public Customer()
        {
            
        }

        //constructors with arguments 
        public Customer(int customerId, string name, int age, double phone, string city)
        {
            Customerid = customerId;
            Name = name;
            Age = age;
            Phonenum = phone;
            City = city;
        }

       

        // Destructor------------
        ~Customer()
        {
            Console.WriteLine("Customer object destroyed.");
        }

        // Static method to display customer details directly without an object
        public static void DisplayCustomer(int customerId, string name, int age, double phone, string city)
        {
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("City: " + city);
        }
        class Dis
        {
            static void Main(string[] args)
            {
                // Prompt user for input
                Console.WriteLine("Enter Customerid:");
                int customerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Phonenum:");
                double phone =  Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();

                Customer.DisplayCustomer( customerId,  name,  age,  phone,  city);
                Console.ReadLine();
            }
        }
    }
}