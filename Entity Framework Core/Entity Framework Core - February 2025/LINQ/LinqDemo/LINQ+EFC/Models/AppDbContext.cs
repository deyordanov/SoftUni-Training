using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LINQ_EFC.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {

    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.Property(e => e.AddressText)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Town).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.TownID)
                .HasConstraintName("FK_Addresses_Towns");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departments_Employees");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HireDate).HasColumnType("smalldatetime");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(15, 4)");

            entity.HasOne(d => d.Address).WithMany(p => p.Employees)
                .HasForeignKey(d => d.AddressID)
                .HasConstraintName("FK_Employees_Addresses");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Departments");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerID)
                .HasConstraintName("FK_Employees_Employees");

            entity.HasMany(d => d.Projects).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeesProject",
                    r => r.HasOne<Project>().WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeesProjects_Projects"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeesProjects_Employees"),
                    j =>
                    {
                        j.HasKey("EmployeeID", "ProjectID");
                        j.ToTable("EmployeesProjects");
                    });
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
