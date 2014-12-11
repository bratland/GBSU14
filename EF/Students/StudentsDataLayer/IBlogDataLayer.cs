using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsDataLayer
{
    public interface IBlogDataLayer
    {
        List<Post> GetPosts();

        List<Author> GetAuthors();
    }
}
