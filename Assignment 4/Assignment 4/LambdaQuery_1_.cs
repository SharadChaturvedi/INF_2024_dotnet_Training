using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class LambdaQuery_1_
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Enter a list of numbers separated by commas:");
                string input = Console.ReadLine();

                var numbers = input.Split(',')
                                   .Select(int.Parse)
                                   .ToList();

                var squaredNumbers = numbers
                    .Select(num => num * num)
                    .Where(square => square > 20);

                Console.WriteLine("Numbers and their squares greater than 20: ");
                Console.WriteLine(string.Join(",", squaredNumbers));
                Console.ReadLine();

            }
        }
    }
}
