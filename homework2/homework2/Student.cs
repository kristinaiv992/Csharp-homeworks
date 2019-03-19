using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Student
    {
        public string name;
        public int age;
        public int id;

        public Student(string Name, int Age, int ID)
        {
            name = Name;
            age = Age;
            id = ID;
        }

        public string PrintStudent()
        {
            Console.WriteLine("------------");
            return ($"The student {name} has {age} years. His ID Card IS : {id}");
        }
    }
}