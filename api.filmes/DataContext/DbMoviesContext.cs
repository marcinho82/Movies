using api.filmes.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Migrations;

namespace api.filmes.DataContext
{
    public class DbMoviesContext : DbContext
    {
        public DbMoviesContext(DbContextOptions<DbMoviesContext> options) : base(options) { 
        
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(x => new { x.userId });

            modelBuilder.Entity<Genres>()
               .HasKey(x => new { x.genreId });

            modelBuilder.Entity<Movies>()
               .HasKey(x => new { x.movieId });

        }

       
        

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Users> Users { get; set; }
       
    }
}
