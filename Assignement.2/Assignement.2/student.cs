using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Create a class called student which has data members like rollno, name, class, Semester, branch, int [] marks=new int marks [5](marks of 5 subjects )

-Pass the details of student like rollno, name, class, SEM, branch in constructor

-For marks write a method called GetMarks() and give marks for all 5 subjects

-Write a method called displayresult, which should calculate the average marks

-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35,but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.

-Write a DisplayData() method to display all values.*/

namespace Assignement._2
{
    class Student


    {
        // Data members/fields
        public int RollNo;
        public string Name;
        public string Class;
        public string Semester;
        public string Branch;
        public int[] Marks = new int[5];

        // Constructor
        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            Class = studentClass;
            Semester = semester;
            Branch = branch;
        }

        // Method to input marks for all 5 subjects
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to calculate the average marks......
        public double calculateAverage()
        {
            double sum = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
            }
            return sum / 5;
        }


        public void Displayresult()
        {
            bool anySubjectFailed = false;
            foreach (int mark in Marks)
            {
                if (mark < 35)
                {
                    anySubjectFailed = true;
                }
            }

            if (anySubjectFailed)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                double average = calculateAverage();
                Console.WriteLine($"Average Marks: {average}");

                if (average < 32)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");

                }


            }
        }
        // methods to display all values .....
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {Marks[i]}");
            }


        }
    }
    class xxxxx
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(420, "Sharad chaubey", "B.tech", "1st", "Engineering");
            student1.GetMarks();            // Input marks for 5 subjects.
            student1.Displayresult();       // Calculate average marks and display result.
            student1.DisplayData();         // Display all data of the student.
            Console.ReadLine();
        }
    }
}







