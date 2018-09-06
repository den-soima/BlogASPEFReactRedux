using System.Collections.Generic;

namespace Models
{
    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public List<Post> Records { get; set; }
        public int TatalPages { get; set; }
    }
}