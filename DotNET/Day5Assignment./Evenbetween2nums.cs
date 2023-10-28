/*Q.Write a method which will accept two number and return all even number 
between it as array and also give count in out variable.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CheckStringMethods
    {
        
        
        public void Accept2Nos(int num1,int num2,out int count)
        {
            count = 0;
            int[] a = new int[(num2-num1)/2+1];
            for (int i=num1; i < num2; i++) 
            {
                if(i%2==0)
                {
                         a[count++] = i;
                }
             }

            for (int k=0; k <a.Length;k++ )
            {
                Console.WriteLine(a[k]);
            }
            
        }

        static void Main(String[] args)
        {
          CheckStringMethods c= new CheckStringMethods();
            Console.WriteLine("Enter first Number: ");
            string n1=Console.ReadLine();
            Console.WriteLine("Enter first Number: ");
            string n2=Console.ReadLine();
            int num1=int.Parse(n1);
            int num2=int.Parse(n2);
            int c1;
            c.Accept2Nos(num1, num2, out c1);
            Console.WriteLine("Even numbers count is  " + c1);
        }
    }
}
