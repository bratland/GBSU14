using System.Data.Entity;

namespace StudentsDataLayer
{
    public class StudentContext: DbContext 
    {
        public StudentContext()
            : base("SchoolDBConnectionString") 
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
