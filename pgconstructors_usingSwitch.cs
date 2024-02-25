using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_day2
{
    
    internal class pgconstructors_usingSwitch
    {
        public void checkinggrades_switch()
        {
            char grade; int math;
            Console.WriteLine("Enter Grade and maths Score");
            grade = Convert.ToChar(Console.ReadLine());
            math = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c'
:
                    Console.WriteLine("Good");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
                }
            }
        }
    }
