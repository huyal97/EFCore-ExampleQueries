﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkExamples.Entities;

public partial class Supplier
{
    public long SupplierId { get; set; }

    public string SupplierName { get; set; }

    public string ContactName { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public string Phone { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
