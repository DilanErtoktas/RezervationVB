using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervationVB.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=CB0322081; database=RezervationDB; integrated security=true;");
        }

        public DbSet<masa> TableMasa { get; set; }
        public DbSet<rezerve> TableRezerve { get; set; }
    }
}
