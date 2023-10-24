//Q.Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o/p 22]
//Which will return square .cube and rounded number.
//Create object and call method and print the result

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        public static double makeSquare(float num1)
        {
            return  num1 * num1 ;
        }
        public static double makeCube(float num1)
        {
            return num1 * num1 * num1;
        }
        public static int makeRound(float num1)
        {
            return (int)num1;
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("Enter numbers for square: ");
            string num = Console.ReadLine();
            float num1=float.Parse(num);
            Console.WriteLine("Square of {0} is {1}",num,makeSquare(num1));
            Console.WriteLine("Cube of {0} is {1}", num, makeCube(num1));
            Console.WriteLine("RounfOff of {0} is {1}", num, makeRound(num1));
        }
    }
}
