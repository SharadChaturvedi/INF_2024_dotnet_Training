using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Code_28feb
{

    /* 1. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
 
Sample Input:
"Python", 1
"Python", 0
"Python", 4
Expected Output:
Pthon
ython
Pythn */

    internal class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            
            string s;
            int n;
            Console.WriteLine("Enter a String and position ");
            string newS = "";  //Empty String
            s = Console.ReadLine();
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (i != n)
                    newS = newS + s[i];
            }
            Console.ReadLine();
        } 
    }
}
        

    
   
    
        
    

