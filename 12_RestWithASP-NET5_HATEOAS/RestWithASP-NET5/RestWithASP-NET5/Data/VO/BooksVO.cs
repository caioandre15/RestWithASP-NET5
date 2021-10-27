using RestWithASP_NET5.HyperMedia;
using RestWithASP_NET5.HyperMedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASP_NET5.Data.VO
{
    public class BooksVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Author { get; set; }
     
        public DateTime LaunchDate { get; set; }
     
        public Decimal Price { get; set; }
     
        public string title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
