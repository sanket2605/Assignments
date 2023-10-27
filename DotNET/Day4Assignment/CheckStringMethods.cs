/*Q.Create 2 string variable and accept data from user.
Using equals and == check data entered by user is same or not.
Print gethashcode for both string .variable
Also use referenceEquals and observe out put.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CheckStringMethods
    { 
        static void Main(String[] args)
        {
            String a, b;

            Console.WriteLine("Enter data for a : ");
            a=Console.ReadLine();
            Console.WriteLine("Enter data for b : ");
            b =Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("EqualTo Operator for both string is "); 
            Console.WriteLine( a == b);
            Console.WriteLine();
            Console.WriteLine("Equals Operator for both string is" + "\t" + string.Equals(a,b));
            Console.WriteLine();
            Console.WriteLine("HashCode for a :" + "\t" + a.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("HashCode for b :" + "\t" + b.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("Reference Equals for both string is");
            Console.WriteLine(string.ReferenceEquals(a,b));
        }
    }
}
