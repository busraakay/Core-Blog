using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPILayer.DataAccsessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-83VGVFE0\\SQLEXPRESS;database=CoreAPIDb; integrated security=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
