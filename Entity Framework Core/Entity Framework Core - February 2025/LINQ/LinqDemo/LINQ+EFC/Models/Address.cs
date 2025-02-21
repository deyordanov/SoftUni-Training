using System;
using System.Collections.Generic;

namespace LINQ_EFC.Models;

public partial class Address
{
    public int AddressID { get; set; }

    public string AddressText { get; set; } = null!;

    public int? TownID { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Town? Town { get; set; }
}
