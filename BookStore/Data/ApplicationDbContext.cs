using eCinema.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCinema.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Movie_Actor>().HasKey(am => new
            {
                am.MovieId,
                am.Id

            });
            modelbuilder.Entity<Movie_Actor>().HasOne(m => m.Movie).WithMany(am => am.Movie_Actors).HasForeignKey(m => m.MovieId);
            modelbuilder.Entity<Movie_Actor>().HasOne(m => m.Actor).WithMany(am => am.Movie_Actors).HasForeignKey(m => m.Id);
            base.OnModelCreating(modelbuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Movie_Actor> movie_Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
