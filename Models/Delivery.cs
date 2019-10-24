﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floral.Models
{
    public class Delivery
    {
            public int Id{ get; set; }
            public bool isDelivery{ get; set; }
            public decimal deliveryPrice{ get; set; }
            public DateTimeOffset createDateTime { get; set; }
            public DateTimeOffset updateDateTime { get; set; }
            public int deliverTimeId{ get; set; }
            public int userDeliveryAddressId{ get; set; }
            public int driverId{ get; set; }
        
    }
}
