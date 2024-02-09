using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data.Models;
using Task = TaskBoardApp.Data.Models.Task;

namespace TaskBoardApp.Data
{
    public class TaskBoardAppDbContext : IdentityDbContext<IdentityUser>
    {
        private IdentityUser TestUser { get; set; }
        private Board OpenBoard { get; set; }
        private Board InProgressBoard { get; set; }
        private Board DoneBoard { get; set; }

        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Board> Board { get; set; }
        public DbSet<Task> Tasks { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<Task>()
            .HasOne(t=>t.Board)
            .WithMany(b=>b.Tasks)
            .HasForeignKey(t=>t.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

			base.OnModelCreating(builder);
		}
	}
}
