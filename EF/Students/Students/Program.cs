using System;
using System.Collections.Generic;
using System.Linq;
using StudentsDataLayer;
using Context = System.Runtime.Remoting.Contexts.Context;

namespace EFSimpleCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var ctx = new StudentContext();
            
            //var newStd = new Standard
            //{ 
            //    StandardName = "Standard 1", 
            //    Description = "New Standard" 
            //};

            //var stud = new Student
            //{
            //    StudentName = "Andreas"
            //};
            //ctx.Students.Add(stud);
            //ctx.Standards.Add(newStd);
            //ctx.SaveChanges();

            foreach (var student in ctx.Students.OrderBy(s => s.StudentName).Take(3))
            {
                Console.WriteLine(student.StudentName);
            }
            


            Console.WriteLine("Code first demo successful");
            Console.ReadKey();
        }
    }
}
