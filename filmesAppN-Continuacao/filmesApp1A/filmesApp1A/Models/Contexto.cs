using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp1A.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Filme> Filme{ get; set; }
        public DbSet<Pais> Pais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseNpgsql("Host=localhost;Database=filmesN;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().HasData(
                    new Pais { Nome = "EUA", Id = 1 },
                    new Pais {  Nome = "Brasil", Id = 2} 
            );
        }
    }
}
