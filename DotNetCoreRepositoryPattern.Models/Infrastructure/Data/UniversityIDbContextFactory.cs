using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreRepositoryPattern.Models.Infrastructure.Data
{
    public class UniversityIDbContextFactory : IDbContextFactory<UniversityContext>
    {
        public UniversityContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<UniversityContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UniversityCoreDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new UniversityContext(builder.Options);
        }
    }
}
