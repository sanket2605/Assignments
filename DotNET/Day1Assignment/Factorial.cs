Q2.Create class library with method fact() which will return factorial of a number. Use it in console application

namespace Factorial
{
    public class Class1
    {
        public int fact(int x)
        {
            int num= 1;
            for(int i = 1; i<=x; i++)
            {
                num*=i;
            }
            return num;
        }
    }
}


namespace ConsoleFact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial.Class1 f = new Factorial.Class1();
            int num = f.fact(4);
            Console.WriteLine("Factorial is {0}",num);
            Console.ReadLine();
        }
    }
}
