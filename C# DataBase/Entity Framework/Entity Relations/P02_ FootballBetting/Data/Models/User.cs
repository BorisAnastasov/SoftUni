using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class User
{
       public User()
       {
              Bets = new HashSet<Bet>();
       }
       [Key]
       public int UserId { get; set; }
       [Required]
       public string Username { get; set; } = null!;
       [Required]
       public string Password { get; set; } = null!;
       [Required]
       public string Email { get; set; } = null!;
       [Required]
       public string Name { get; set; } = null!;
       [Required]
       public decimal Balance { get; set; }

       [InverseProperty(nameof(Bet.User))]
       public virtual ICollection<Bet> Bets { get; set; } = null!;
}
