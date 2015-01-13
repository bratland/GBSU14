using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Post
    {
        public int PostId { get; set; }

        public string Tags { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
