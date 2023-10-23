//Q.Create a class student in namespace DAC and in namespace DBDA write method add in both class. In entry point call both method
namespace DAC
{
    internal class Students
    {
        public void Add()
        {
            Console.WriteLine("DAC student added");
        }
       
    }
}
namespace DBDA
{
    internal class Students
    {
        public void Add()
        {
            Console.WriteLine("DBDA student added");
        }
    }
}
namespace Demo
{
    internal class MyClass
    {
        static void Main(string[] args)
        {
            DAC.Students s1 = new DAC.Students();
            DBDA.Students s2 = new DBDA.Students();
            s1.Add();
            s2.Add();
        }
    }
}


