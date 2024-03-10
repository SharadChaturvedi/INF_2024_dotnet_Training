using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Concession;



namespace TestClinet
{
    // Create a Console application to test the above project.Inside Class Program have int TotalFare as Constant, Name, Age as properties.
    // Accept Name, Age from the user and call the CalculateConcession() method and print the details accordingly

    internal class Program
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public static void Main(string[] args)
        {

            //string name;
            //int age;


            //Console.WriteLine("Enter your name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());

            //TicketConcession tc = new TicketConcession();
            //tc.CalculateConcession(name,age);

            LambdaQuery lc =new LambdaQuery();
            lc.Sqaure();
            lc.Places_AM();
            Console.ReadLine();


        }
    }
}

