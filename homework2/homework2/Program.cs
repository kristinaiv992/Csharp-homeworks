using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                //creating an array of objects example of array: int[] array = new int [5];
                Student[] students = new Student[4];
                //initlising objects by constructors
                students[0] = new Student("hercules", 29, 3340981);
                //reading and printing first object
                students[1] = new Student("tarzan", 34, 3340982);
                students[2] = new Student("superman", 24, 3340983);
                students[3] = new Student("spiderman", 39, 3340984);

                //Enter a student name and check if the student is a part of my Students array
                Console.WriteLine("Please enter a student? Example: Tarzan, Ironman, Venom");
                var nameStud = Console.ReadLine().ToLower();
                bool foundTheStud = false;
                for (int i = 0; i < students.Length; i++)
                {
                    if (!foundTheStud)
                    {
                        if (nameStud == students[i].name)
                        {
                            Console.Write(students[i].PrintStudent());
                            foundTheStud = true;
                        }
                    }

                }

                if (!foundTheStud)
                {
                    Console.WriteLine("There is no student in the Academy with such name, press enter to continue");
                }
                else
                {
                    foundTheStud = false;
                }

                Console.ReadKey();
            }
        }
    }
}