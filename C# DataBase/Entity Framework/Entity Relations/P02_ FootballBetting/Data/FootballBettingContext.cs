﻿using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Data.Models;

namespace P02_FootballBetting.Data;

public class FootballBettingContext : DbContext
{
       public FootballBettingContext()
       {

       }

       public FootballBettingContext(DbContextOptions options) : base(options)
       {

       }
       //Tables
       public DbSet<Team> Teams { get; set; }
       public DbSet<Color> Colors { get; set; }
       public DbSet<Town> Towns { get; set; }
       public DbSet<Country> Countries { get; set; }
       public DbSet<Player> Players { get; set; }
       public DbSet<Position> Positions { get; set; }
       public DbSet<PlayerStatistic> PlayersStatistics { get; set; }
       public DbSet<Game> Games { get; set; }
       public DbSet<Bet> Bets { get; set; }
       public DbSet<User> Users { get; set; }


       //Configuration
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
              if (!optionsBuilder.IsConfigured) 
              {
                     optionsBuilder.UseSqlServer(Config.connection_string);
              }
              base.OnConfiguring(optionsBuilder);
       }


       //Fluent API

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
              modelBuilder.Entity<PlayerStatistic>(entity =>
              {
                     entity.HasKey(pk => new { pk.PlayerId, pk.GameId });
              });

              base.OnModelCreating(modelBuilder);
       }

}
