using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_day2
{
    internal class Program_constructors
    {

        static void Main(string[] args)
        {
            pgconstructors_usingSwitch pg = new pgconstructors_usingSwitch();
            pg.checkinggrades_switch();
            CheckingGrades();
        }



        //if_else 
        public static void CheckingGrades()
        {
            char grades;
            int maths = 500;
            Console.WriteLine("Enter the Grades O/A/B/C");
            grades = Convert.ToChar(Console.ReadLine());

            if
                ((grades == 'O' || grades == 'o') && (maths > 90))
                Console.WriteLine("outstanding");
            else if
                ((grades == 'A'))
                Console.WriteLine("Excelent");
            else if
                (grades == 'B')
                Console.WriteLine("Very Good ");
            else if
                (grades == 'C')
                Console.WriteLine("Good");

            else
                Console.WriteLine("Invalid Grade");

        }





    }
}

