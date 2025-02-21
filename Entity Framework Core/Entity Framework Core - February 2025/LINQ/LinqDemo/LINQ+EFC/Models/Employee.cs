using System;
using System.Collections.Generic;

namespace LINQ_EFC.Models;

public partial class Employee
{
    public int EmployeeID { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string JobTitle { get; set; } = null!;

    public int DepartmentID { get; set; }

    public int? ManagerID { get; set; }

    public DateTime HireDate { get; set; }

    public decimal Salary { get; set; }

    public int? AddressID { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual Employee? Manager { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
