using System.Collections.Generic;

namespace BlogModel
{
    public class BlogEntry
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return Title + " - " + Id;
        }

        public List<Comment> Comments { get; set; }
    }
}
