using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp.Data.Models;

namespace TaskBoardApp.Data.Configuration
{
	public class BoardConfiguration:IEntityTypeConfiguration<Board>
	{
		public static Board openBoard = new Board()
		{
			Id = 1,
			Name = "Open"
		};

		public static Board inProgressBoard = new Board()
		{
			Id = 2,
			Name = "In Progress"
		};

		public static Board doneBoard = new Board()
		{
			Id = 3,
			Name = "Done"
		};

		public void Configure(EntityTypeBuilder<Board> builder)
		{
			builder.HasData(openBoard, inProgressBoard, doneBoard);

		}
	}
}
