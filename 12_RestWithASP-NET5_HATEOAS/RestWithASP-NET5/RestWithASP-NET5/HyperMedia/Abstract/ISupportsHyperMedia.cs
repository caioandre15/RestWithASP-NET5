using System.Collections.Generic;

namespace RestWithASP_NET5.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }

    }
}
