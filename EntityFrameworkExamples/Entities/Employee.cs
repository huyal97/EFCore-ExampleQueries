using System;
using System.Collections.Generic;

namespace EntityFrameworkExamples.Entities;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public byte[] BirthDate { get; set; }

    public string Photo { get; set; }

    public string Notes { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
