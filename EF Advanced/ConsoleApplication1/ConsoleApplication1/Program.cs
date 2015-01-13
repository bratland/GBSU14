using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EagerLoading();
            EagerMultiLevel();
            LazyFilter();
            LazyCount();
        }

        private static void LazyCount()
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(1);

                // Count how many posts the blog has  
                var postCount = context.Entry(blog)
                    .Collection(b => b.Posts)
                    .Query()
                    .Count();
            }
        }

        private static void LazyFilter()
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(1);

                // Load the posts with the 'entity-framework' tag related to a given blog 
                context.Entry(blog)
                    .Collection(b => b.Posts)
                    .Query()
                    .Where(p => p.Tags.Contains("entity-framework"))
                    .Load();
            }
        }

        private static void EagerLoading()
        {
            //Eager Loading
            using (var context = new BloggingContext())
            {
                // Load all blogs and related posts 
                var blogs1 = context.Blogs
                    .Include(b => b.Posts)
                    .ToList();

                // Load one blogs and its related posts 
                var blog1 = context.Blogs
                    .Where(b => b.Name == "ADO.NET Blog")
                    .Include(b => b.Posts)
                    .FirstOrDefault();

                //// Load all blogs and related posts using a string to specify the relationship 
                //var blogs2 = context.Blogs
                //    .Include("Posts")
                //    .ToList();

                //// Load one blog and its related posts using a string to specify the relationship 
                //var blog2 = context.Blogs
                //    .Where(b => b.Name == "ADO.NET Blog")
                //    .Include("Posts")
                //    .FirstOrDefault();
            }
        }

        private static void EagerMultiLevel()
        {
            using (var context = new BloggingContext())
            {
                // Load all blogs, all related posts, and all related comments 
                var blogs1 = context.Blogs
                                   .Include(b => b.Posts.Select(p => p.Comments))
                                   .ToList();


                // Load all blogs, all related posts, and all related comments  
                // using a string to specify the relationships 
                var blogs2 = context.Blogs
                                   .Include("Posts.Comments")
                                   .ToList();

            }
        }
    }
}
