using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class LibraryDbContext : DbContext

    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Membre> Membres { get; set; }

        public DbSet<Livre> Livres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your MySQL connection string here
            optionsBuilder.UseMySql("server=localhost;database=library;user=root;password=");
        }
    }
}
