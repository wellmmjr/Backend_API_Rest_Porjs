﻿using System.Collections.Generic;

namespace RestWithASPNet.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
