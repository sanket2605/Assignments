//Q.Create class calculator with two method Add and product. Create object and call method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleD1
{
    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Product(int x, int y) 
        {
            return x * y;
        }
        static void Main(string[] args)
        {
           
           Calculator c1 = new Calculator();
            int sum=c1.Add(4, 5);
            int prod=c1.Product(4, 5);
            Console.WriteLine("sum is {0} and product is {1}", sum, prod);
        }
    }
}
