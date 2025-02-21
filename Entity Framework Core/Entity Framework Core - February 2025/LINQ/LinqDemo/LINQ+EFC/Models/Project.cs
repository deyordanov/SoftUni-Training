using System;
using System.Collections.Generic;

namespace LINQ_EFC.Models;

public partial class Project
{
    public int ProjectID { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
