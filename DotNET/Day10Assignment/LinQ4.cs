//Q.int[] a={5,8,9,2,1}; display all numbers greater than or equal to 8

namespace Day10
{
    internal class LinQ4
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 9, 2, 1 };

          //using LinQ
            var subset= from i in a where i>=8 select i;
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
          //using Lambda
            var subset1=a.Where(i => i >= 8).Select(i => i);
            foreach (var item in subset1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
