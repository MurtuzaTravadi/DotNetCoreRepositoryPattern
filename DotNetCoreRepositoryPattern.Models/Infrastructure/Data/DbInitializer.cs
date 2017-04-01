using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreRepositoryPattern.Models.Infrastructure.Data
{
    public class DbInitializer
    {
        public static void Initialize(UniversityContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
