using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battalion
{
    public class BattalionContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB;Database=WorkPlace;Trusted_Connection=True;");
        }
    }
}
