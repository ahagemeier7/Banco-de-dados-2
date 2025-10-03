using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Cinema.Models;

namespace Cinema.Data
{
    public class CinemaContext : DbContext
    {

        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {

        }

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<GenerosFilmes> GenerosFilmes { get; set; }
        public DbSet<ReviewsFilmes> ReviewsFilmes { get; set; }
        //public DbSet<GenerosFilmes> generosfilmes { get; set; }
        //public DbSet<GenerosFilmes> generosfilmes { get; set; }
        //public DbSet<GenerosFilmes> generosfilmes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filmes>().ToTable("filmes");
            modelBuilder.Entity<Generos>().ToTable("generos");
            modelBuilder.Entity<GenerosFilmes>().ToTable("generos_filmes");
            modelBuilder.Entity<ReviewsFilmes>().ToTable("reviews_filmes");
        }
    }
}
