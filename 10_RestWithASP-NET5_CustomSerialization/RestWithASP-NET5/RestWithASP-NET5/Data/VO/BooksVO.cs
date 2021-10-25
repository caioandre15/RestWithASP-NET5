using System;

namespace RestWithASP_NET5.Data.VO
{
    public class BooksVO
    {
        public long Id { get; set; }

        public string Author { get; set; }
     
        public DateTime LaunchDate { get; set; }
     
        public Decimal Price { get; set; }
     
        public string title { get; set; }
    }
}
