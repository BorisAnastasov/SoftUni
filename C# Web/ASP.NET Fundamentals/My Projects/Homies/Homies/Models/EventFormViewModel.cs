using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants;
using Type = Homies.Data.Models.Type;

namespace Homies.Models
{
	public class EventFormViewModel
	{
		[Required(ErrorMessage = RequireErrorMessage)]
		[StringLength(EventNameMax, MinimumLength = EventNameMin,ErrorMessage =StringLengthErrorMessage)]
		public string Name { get; set; } = null!;

		[Required(ErrorMessage = RequireErrorMessage)]
		[StringLength(EventDescriptionMax, MinimumLength = EventDescriptionMin, ErrorMessage = StringLengthErrorMessage)]
		public string Description { get; set; } = null!;

		[Required(ErrorMessage = RequireErrorMessage)]
		public string Start { get; set; } = string.Empty;

		[Required(ErrorMessage = RequireErrorMessage)]
		public string End { get; set; } = string.Empty;

		[Required(ErrorMessage = RequireErrorMessage)]
		public int TypeId { get; set; }

		public IEnumerable<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();
    }
}
