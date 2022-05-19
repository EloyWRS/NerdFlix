using Microsoft.EntityFrameworkCore;
using Movies_MVC_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MVC_6.Data
{
    public class MovieContext : DbContext
    {
       
            public MovieContext(DbContextOptions<MovieContext> options) : base(options)
            { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Movie>().ToTable("Movie");
                modelBuilder.Entity<Award>().ToTable("Award");
                modelBuilder.Entity<MovieAward>().ToTable("MovieAward");
                modelBuilder.Entity<Award>().HasKey(e => e.AwardID);
            }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Award> Awards { get; set; }
            public DbSet<MovieAward> MovieAward { get; set; }
        
    }
}
