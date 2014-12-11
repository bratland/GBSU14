using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataLayer
{
    public class EFBlogDataLayer : IBlogDataLayer
    {
        private MyModel _db;
        public EFBlogDataLayer()
        {
            _db = new MyModel();
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
