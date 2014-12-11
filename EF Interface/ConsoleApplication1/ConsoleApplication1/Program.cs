using System;
using System.Configuration;
using Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyName = ConfigurationManager.AppSettings["assembly"];
            var typeName = ConfigurationManager.AppSettings["typeName"];
            var db = (IDbLayer)Activator.CreateInstance(assemblyName, typeName).Unwrap();

            var students = db.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine(student.StudentName);
            }

            Console.ReadLine();
        }
    }
}
