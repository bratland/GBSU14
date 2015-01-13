using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        //Lazy
        public virtual ICollection<Post> Posts { get; set; }

        //Eager
        //public ICollection<Post> Posts { get; set; }
    }
}