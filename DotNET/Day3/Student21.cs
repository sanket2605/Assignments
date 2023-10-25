//Create a class student with member variable name, maths, science, eng
//Create a method which will return total marks[300]
//Create a method which will display name and total.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        string name;
        int maths;
        int sci;
        int eng;
        static int stotal;

        static Student()
        {
          Console.WriteLine("SM-VITA");
        }

        public Student(string name, int maths, int sci, int eng)
        {
            this.name = name;
            this.maths = maths;
            this.sci = sci;
            this.eng = eng;
        }

        public static int totalmarks(Student obj)
        {
            stotal = obj.maths + obj.sci + obj.eng;
            return stotal;
        }
        public static void display(Student obj) 
        {
            Console.WriteLine("Name: "+obj.name+"\t"+"Total Marks: "+totalmarks(obj)+"  out of 300");
        }
        static void Main(string[] args)
        {
           Student s = new Student("Sanket",50,60,70);
            totalmarks(s);
            display(s);
           Student r = new Student("Rohit", 60, 90, 80);
            totalmarks(r);
            display(r);
        }
    }
}
