namespace TaskBoardApp.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using static TaskBoardApp.Data.DataConstants.Board;
	public class Board
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(BoardMaxName)]
		public string Name { get; set; } = null!;

		public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
	}
}
