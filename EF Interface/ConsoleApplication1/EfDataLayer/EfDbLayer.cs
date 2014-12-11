using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace EfDataLayer
{
    public class EfDbLayer : IDbLayer
    {
        public List<Student> GetStudents()
        {
            var db = new EfDataModel();

            return db.Students.OrderBy(s => s.StudentName).ToList();
        }
    }
}
