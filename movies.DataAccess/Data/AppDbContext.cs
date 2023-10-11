using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies.Models;

namespace movies.DataAccess;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor_Movie>().HasKey(am=>new{
            am.ActorId,
            am.MovieId
        });
        modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Movie).WithMany(am=>am.Actor_Movie).HasForeignKey(m=>m.MovieId);
        modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Actor).WithMany(am=>am.Actor_Movie).HasForeignKey(m=>m.ActorId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Actor>Actors {get;set;}
    public DbSet<Producer>Producers {get;set;}
    public DbSet<Cinema>Cinemas {get;set;}
    public DbSet<Movie>Movies {get;set;}
    public DbSet<Actor_Movie>Actor_Movies {get;set;}


}