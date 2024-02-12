namespace Homies.Data
{
	public static class DataConstants
	{
		public const int EventNameMin = 5;
		public const int EventNameMax = 20;

		public const int EventDescriptionMin = 15;
		public const int EventDescriptionMax = 150;

		public const string DateFormat = "yyyy-MM-dd H:mm";

		public const int TypeNameMin = 5;
		public const int TypeNameMax = 15;


		public const string RequireErrorMessage = "The field {0} is required.";
		public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long.";
	}
}
