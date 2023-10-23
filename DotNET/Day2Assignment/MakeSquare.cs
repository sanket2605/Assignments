//Q.Accept a float value and print square of that number. Solve above code using Parse(), ToSingle() and TryPrase() method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class MakeSquare
    {
        public static float sqr(float x)
        {
            return x*x;
        }
        static void Main(string[] args)
        {
            MakeSquare m1 = new MakeSquare();
            Console.WriteLine("Enter the number: ");
            string num1 = Console.ReadLine();

            int intNum1=int.Parse(num1);
            Console.WriteLine("Square of {0} is {1}", num1, sqr(intNum1));

            int.TryParse(num1, out int a );
            Console.WriteLine("Squqre of {0} is {1}", num1, sqr(a));

            float f=Convert.ToSingle(num1);
            Console.WriteLine("Squqre of {0} is {1}", num1, sqr(f));
        }
    }
}
