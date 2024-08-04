using EF_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Context
{
    internal class ApplicationDbContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ASP9_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
