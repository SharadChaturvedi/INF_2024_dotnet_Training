using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Code_28feb
{
    internal class second_question
    {
        public second_question() {
            string s;
            char temp;
            Console.WriteLine("Enter a string: ");   
            s = Console.ReadLine();
            int len = s.Length;
            return s[len - 1] + s.Substring(1, len - 2) + s[0];

           
            char Last = s[len - 1];   
            Console.WriteLine(Last);
            char first;
            int LastChar = s.Length - 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || i == s.Length - 1)
                {

                    temp = s[i];   
                    s[LastChar] = temp;


                }

            }
            return s;
           








        }




