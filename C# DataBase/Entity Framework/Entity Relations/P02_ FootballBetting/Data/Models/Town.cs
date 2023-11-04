using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Town
{
       public Town()
       {
              Teams = new HashSet<Team>();
       }
       [Key]
       public int TownId { get; set; }

       [Required]
       public string Name { get; set; } = null!;

       public int CountryId { get; set; }
       public virtual Country Country { get; set; } = null!;

       public virtual ICollection<Team> Teams { get; set; } = null!;


}
