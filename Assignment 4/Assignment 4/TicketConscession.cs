using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_4 { 
    class TicketConcession

{
        //keeping the total fare 100 .constant integer

        const int TOTAL_FARE = 100;
        public Action<string, int> CalculateConcession = (name, age) =>
        //Action<string, int> declares a delegate type that represents a method taking a string and an integer as parameters.
        //we are giving name as string and age as integer here .
        {
            if (age <= 5)
            {
                Console.WriteLine($"{name} - Age: {age} - Little Champs- Free Ticket");
            }
            else if (age > 60)
            {
                double concessionAmount = 0.3 * TOTAL_FARE;
                double calculatedFare = TOTAL_FARE - concessionAmount;
                Console.WriteLine($"{name} - Age: {age} - Senior Citizen - Calculated Fare: {calculatedFare}");
            }
            else
            {
                Console.WriteLine($"{name} - Age: {age} - Ticket Booked - Fare: {TOTAL_FARE}");
            }
        };
}

class concessionvalues
{
     public static void Main(string[] args)
    {
            
            // This is here to provide the user input and print the desired values .....

            Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        var concession = new TicketConcession();
        concession.CalculateConcession(name, age);
            Console.ReadLine();
    }
  }

}

/*   output 
 * Enter your name:
Sharad
Enter your age:
2
Sharad  - Age: 2 - Little Champs- Free Ticket 
-----------------------------------------------
Enter your name:
sharad
Enter your age:
70
sharad  - Age: 70 - Senior Citizen - Calculated Fare: 700
--------------------------------------------
Enter your name:
sharad
Enter your age:
45
sharad  - Age: 45 - Ticket Booked - Fare: 1000
 
*/
