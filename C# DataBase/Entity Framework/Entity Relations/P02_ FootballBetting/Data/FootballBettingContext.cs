using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using P01_StudentSystem.Data;

namespace P02__FootballBetting.Data;

public class FootballBettingContext : DbContext
{
       public FootballBettingContext()
       {

       }

       public FootballBettingContext(DbContextOptions options) : base(options)
       {

       }
       //Tables

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
              

              base.OnModelCreating(modelBuilder);
       }

}
