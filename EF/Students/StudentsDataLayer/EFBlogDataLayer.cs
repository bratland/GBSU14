using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataLayer
{
    public class EFBlogDataLayer : IBlogDataLayer
    {
        private StudentContext _db;
        public EFBlogDataLayer()
        {
            _db = new StudentContext();
        }

        public List<Post> GetPosts()
        {
            return _db.Posts.ToList();
        }

        public List<Author> GetAuthors()
        {
            return _db.Authors.ToList();
        }
    }
}
