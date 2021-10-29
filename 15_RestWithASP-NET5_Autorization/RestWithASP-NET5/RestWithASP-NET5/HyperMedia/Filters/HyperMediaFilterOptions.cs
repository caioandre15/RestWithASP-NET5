using RestWithASP_NET5.HyperMedia.Abstract;
using System.Collections.Generic;

namespace RestWithASP_NET5.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
