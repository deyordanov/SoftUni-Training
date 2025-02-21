using System;
using System.Collections.Generic;

namespace LINQ_EFC.Models;

public partial class Town
{
    public int TownID { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
