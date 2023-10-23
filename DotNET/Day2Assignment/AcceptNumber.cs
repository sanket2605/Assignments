using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class AcceptNumber
    {
        public static int GetSum(int x,int y) 
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            AcceptNumber x = new AcceptNumber();
            Console.WriteLine("Enter 1st number: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd number: ");
            string num2 = Console.ReadLine();
            int.TryParse(num1, out int a);
            int.TryParse(num2, out int b);
            Console.WriteLine("output is: " + GetSum(a,b));
        }
    }
}
