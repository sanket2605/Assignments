//Q.int[] a={5,8,9,2,1}; display all number<=5.
namespace Day10
{
    internal class LinQ1
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 9, 2, 1 };
             
            var subset= from i in a where i<=5 select i;
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
            var subset1=a.Where(i => i<=5).Select(i => i);
            foreach (var item in subset1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
