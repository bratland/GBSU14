using System.Collections.Generic;
using System.Data.SqlClient;
using Model;

namespace AdoDataLayer
{
    public class AdoDbLayer : IDbLayer
    {
        public List<Student> GetStudents()
        {
            var con =
                new SqlConnection("Data Source=.;Initial Catalog=SchoolDB-ByConnectionString;Integrated Security=True");

            var cmd = con.CreateCommand();
            cmd.CommandText = "select * from students";
            con.Open();

            var reader = cmd.ExecuteReader();

            var students = new List<Student>();

            while (reader.Read())
            {
                students.Add(new Student {StudentName = reader["StudentName"].ToString()}); 
            }
            con.Close();
            return students;
        }
    }
}
