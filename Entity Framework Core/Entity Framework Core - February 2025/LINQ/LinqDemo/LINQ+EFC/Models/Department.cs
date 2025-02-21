using System;
using System.Collections.Generic;

namespace LINQ_EFC.Models;

public partial class Department
{
    public int DepartmentID { get; set; }

    public string Name { get; set; } = null!;

    public int ManagerID { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Employee Manager { get; set; } = null!;
}
