//Q.int[] a={5,8,9,2,1}; display all Even numbers

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 9, 2, 1 };
             
            var subset= from i in a where i%2==0 select i;
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
            var subset1=a.Where(i => i%2==0).Select(i => i);
            foreach (var item in subset1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
