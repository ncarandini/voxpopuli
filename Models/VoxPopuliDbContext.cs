using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Models
{
    public class VoxPopuliDbContext : DbContext
    {
        public DbSet<Suggerimento> Suggerimenti { get; set; }
        public DbSet<Segnalazione> Segnalazioni { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Setting Segnalazione's properties
            modelBuilder.Entity<Segnalazione>().Property(t => t.Descrizione).IsRequired();
            modelBuilder.Entity<Segnalazione>().HasIndex(t => t.Descrizione);

           
        }

    }
}
