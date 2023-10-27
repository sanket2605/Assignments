/*Q. Write a method which will return sum of digit and using out 
    variable let it send count of digit also.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CheckSumCount
    {
        public int SumOfDigits(int number, out int digitCount)
        {
            int sum = 0;
            digitCount = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                digitCount++;
                number /= 10;
            }
            return sum;
        }

        static void Main(String[] args)
        {
            CheckStringMethods c = new CheckStringMethods();
            int count;
            int SOD=c.SumOfDigits(123, out count);
            Console.WriteLine("Sum of digits is "+SOD);
            Console.WriteLine("Countof digits is " + count);

        }
    }
}
