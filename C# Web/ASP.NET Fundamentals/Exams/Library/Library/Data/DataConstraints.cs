namespace Library.Data
{
	public static class DataConstraints
	{
		public static class ApplicationUser 
		{ 
			public const int UserNameMax = 20;
			public const int UserNameMin = 5;

			public const int EmailMax = 60;
			public const int EmailMin = 10;

			public const int PasswordMax = 20;
			public const int PasswordMin = 5;
		}

        public static class Book
        {
			public const int TitleMax = 60;
			public const int TitleMin = 10;

			public const int AuthorMax = 50;
			public const int AuthorMin = 5;

			public const int DescriptionMax = 5000;
			public const int DescriptionMin = 5;

			public const double RatingMax = 10.00;
			public const double RatingMin = 0.00;
		}

		public static class Category 
		{
			public const int NameMin = 5;
			public const int NameMax = 50;
		}
    }
}
