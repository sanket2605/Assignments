//Q.int[] a={5,8,9,2,1}; display all Even numbers

namespace Day10
{
    internal class LinQ2
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 9, 2, 1 };

            //using LinQ
            var subset= from i in a where i%2==0 select i;
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
            //using Lambda
            var subset1=a.Where(i => i%2==0).Select(i => i);
            foreach (var item in subset1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
