using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class DbServices
    {
        private static readonly SchoolContext db= new SchoolContext();
        public void Display()
        {
            foreach (var r in db.Student.ToList<Student>())
            {
                Console.WriteLine(r);                
            }
        }
        public void AddData(Student s)
        {
            db.Add<Student>(s);
            db.SaveChanges();
        }
        public void DeleteData(int id)
        {
            Student student = db.Student.SingleOrDefault<Student>((Stu=>Stu.StudentId==id));
            if (student != null)
            {
                db.Remove<Student>(student);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("<<<---GIVEN---ID---IS---INVALID--->>>");
            }
        }
        public List<Student> CustomQuery(string name)
        {
            FormattableString sql = $"SELECT * FROM Student WHERE FirstName ={name}";
            var studentlist = db.Student.FromSql(sql).ToList();
            return studentlist;
        }

        public void LinqDemo()  //joining two tables and printing 
        {
            var r = db.Grade.Join(db.Student, (sg) => sg.Id, (gi) => gi.GradeId, (sg,gi) => new {gi.FirstName,gi.LastName,sg.GradeName,sg.Section});
            foreach (var item in r)
            {
                Console.WriteLine(item.GradeName + "   " + item.Section + "   " + item.FirstName+ " "+ item.LastName);
            }
        }
    }

}
