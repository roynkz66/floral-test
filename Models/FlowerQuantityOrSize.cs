﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floral.Models
{
    public enum Size { 
        
    small,medium,large

    }
    public class FlowerQuantityOrSize
    {
            public int Id { get; set; }
            public bool isQuantity { get; set; }
            public bool isSize { get; set; }
            public int quantity { get; set; }
            public Size size { get; set; }
            public int PackageId { get; set; }
            public FlowerPackage FlowerPackage { get; set; }
            public DateTimeOffset createDateTime { get; set; }
            public DateTimeOffset updateDateTime { get; set; }
    }
}
