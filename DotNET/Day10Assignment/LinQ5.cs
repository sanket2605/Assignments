/*Q.String[] str = {“hello”,”hi”,”go”,”bye”} display all string starting with letter h*/

namespace Day10
{
    internal class LinQ5
    {
        static void Main(string[] args)
        {
            string[] str = { "hello","hi","go","bye"};

            //using LinQ
            var subset= from i in str where i.StartsWith("h") select i;
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }

            //Using Lambda
            var subset1=str.Where(i => i.StartsWith("h")).Select(i => i);
            foreach (var item in subset1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
