﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
	public class ApplicationUserBook
	{
		[ForeignKey(nameof(ApplicationUser))]
		public string ApplicationUserId { get; set; } = null!;

		public ApplicationUser ApplicationUser { get; set; } = null!;

		[ForeignKey(nameof(Book))]
		public int BookId { get; set; }

		public Book Book { get; set; } = null!;
	}
}
