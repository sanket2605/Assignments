using CodeFirstDemo.Models;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices services = new DbServices();

            Student student = new Student { FirstName= "Soham", LastName="Tale", DateOfBirth=new DateTime(1999,08,15,0,0,0),Height=173,Weight=60,GradeId=5};
            services.AddData(student);  //to add data from user
            
            
            services.DeleteData(9);     //to delete data using ID
            
            
            List<Student> ls = services.CustomQuery("Shantanu");       //to get records by given name
            foreach (Student s in ls) 
            {
                Console.WriteLine(s);
            }
            
            
            services.Display();         //to display all records 
            
            
            services.LinqDemo();       //to join two tables and printing
        }
    }
}
