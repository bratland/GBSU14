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

            IBlogDataLayer db = new EFBlogDataLayer();

            foreach (var author in db.GetAuthors())
            {
                Console.WriteLine(author);
            }

            Console.WriteLine("Code first demo successful");
            Console.ReadKey();
        }
    }
}
