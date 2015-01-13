using System.Configuration;
using System.Data.Entity;

namespace ConsoleApplication1
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}