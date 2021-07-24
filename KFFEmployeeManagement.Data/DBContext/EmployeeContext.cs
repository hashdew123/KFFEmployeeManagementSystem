
using KFFEmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Data.DBContext
{
    public class EmployeeContext : DbContext
    { 
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
    }
}
