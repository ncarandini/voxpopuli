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
        

    }
}
