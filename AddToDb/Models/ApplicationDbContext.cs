using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddToDb.Models
{
    
    
        public class ApplicationDbContext : DbContext

        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            public DbSet<Game> Games
            { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Game>().HasData(new Game{ Id = 1, Title = "Witcher 3", Autor = "CD project red", RealseDay = "Nevim" });
               


            }
        }
    
}
