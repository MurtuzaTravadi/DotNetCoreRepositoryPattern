using DotNetCoreRepositoryPattern.Models.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreRepositoryPattern.Models.Infrastructure.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<UserSubjectMapping> UserSubjectMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Lecture>().ToTable("Lecture");
            modelBuilder.Entity<UserSubjectMapping>().ToTable("UserSubjectMapping");
        }
    }
}
