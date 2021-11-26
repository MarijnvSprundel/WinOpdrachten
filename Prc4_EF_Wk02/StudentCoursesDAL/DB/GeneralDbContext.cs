using Microsoft.EntityFrameworkCore;
using StudentCoursesDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoursesDAL.DB
{
    public class GeneralDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(connectionString: 
                @"server=localhost;database=studentDb;uid=root;password=;", 
                serverVersion: new MySqlServerVersion(new Version(5, 7, 33)));
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
