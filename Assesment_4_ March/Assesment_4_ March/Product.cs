using Assesment_4__March;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4__March

        /*2. Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
         * sort them based on the price, and display the sorted Products*/
{



    public class Product //created the class called product with datamembers;
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        class Program
        {

            static void Main(string[] args)
            {
                Product[] products = new Product[10];

                                                       // Accept 10 products from the user
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter details for product {i + 1}:");
                    Console.Write("Product ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    products[i] = new Product { ProductId = id, ProductName = name, Price = price };
                }

                         // Sorting the products based on price
                Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));

                         // Display the sorted products
                      Console.WriteLine("\nSorted Products based on price:");
                      foreach (var product in products)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
                    Console.ReadLine();
                }

            }

        }

    }
} 
//output 

 /*Enter details for product 1:
Product ID: 1
Product Name: a
Price: 1
Enter details for product 2:
Product ID: 2
Product Name: b
Price: 2
Enter details for product 3:
Product ID: 3
Product Name: c
Price: 3
Enter details for product 4:
Product ID: 4
Product Name: d
Price: 4
Enter details for product 5:
Product ID: 5
Product Name: e
Price: 5
Enter details for product 6:
Product ID: 6
Product Name: f
Price: 6
Enter details for product 7:
Product ID: 8
Product Name: f
Price: 8
Enter details for product 8:
Product ID: 23
Product Name: we
Price: 34
Enter details for product 9:
Product ID: 12
Product Name: deded
Price: 54
Enter details for product 10:
Product ID: 12
Product Name: dedef
Price: 45

Sorted Products based on price:
Product ID: 1, Product Name: a, Price: 1
 */




