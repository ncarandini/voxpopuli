using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Dati
{
    public class VoxPopuliDbContext : DbContext
    {
        public DbSet<Suggerimento> Suggerimenti { get; set; }
        public DbSet<Segnalazione> Segnalazioni { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Setting Segnalazione's properties
            modelBuilder.Entity<Segnalazione>().Property(t => t.Descrizione).IsRequired();
            modelBuilder.Entity<Segnalazione>().Property(t => t.DataSegnalazione).IsRequired();
            modelBuilder.Entity<Segnalazione>().HasIndex(t => t.Descrizione);

            //Setting Suggerimento's properties
            modelBuilder.Entity<Suggerimento>().Property(t => t.Descrizione).IsRequired();
            modelBuilder.Entity<Suggerimento>().Property(t => t.Voti).IsRequired();
            modelBuilder.Entity<Suggerimento>().Property(t => t.Titolo).IsRequired();
            modelBuilder.Entity<Suggerimento>().HasIndex(t => t.Data);
            modelBuilder.Entity<Suggerimento>().HasIndex(t => t.Descrizione);
            modelBuilder.Entity<Suggerimento>().HasIndex(t => t.Titolo);
        }

    }
}
