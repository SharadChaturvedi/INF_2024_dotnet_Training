using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class LambdaQuery_2_
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Write the name of the place starting from a and ending with m");
            string input = Console.ReadLine();

            string[] words = input.Split(',');

            var Places = words
                .Where(word => word.Trim().StartsWith("a") && word.Trim().EndsWith("m"));

            Console.WriteLine(" The name of the places started from a and ending with m are :");
            foreach (var word in Places)
            {
                Console.Write(word.Trim());
                Console.ReadLine();
            }

        }
    }
}
