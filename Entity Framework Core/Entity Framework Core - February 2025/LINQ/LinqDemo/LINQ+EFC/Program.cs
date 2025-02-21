using LINQ_EFC.Models;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer("ConnectionString")
    .Options;

using var dbContext = new AppDbContext(options);