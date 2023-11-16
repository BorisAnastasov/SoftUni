using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Position
{
       public Position()
       {
              Players = new HashSet<Player>();
       }
       [Key]
       public int? PositionId { get; set; }
       [Required]
       public string Name { get; set; } = null!;

       [InverseProperty(nameof(Player.Position))]
       public virtual ICollection<Player> Players { get; set; } = null!;
}
