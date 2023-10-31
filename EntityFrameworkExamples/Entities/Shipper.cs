using System;
using System.Collections.Generic;

namespace EntityFrameworkExamples.Entities;

public partial class Shipper
{
    public long ShipperId { get; set; }

    public string ShipperName { get; set; }

    public string Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
