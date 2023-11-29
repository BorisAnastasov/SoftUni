using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models;

public class Seller
{
       public Seller()
       {
              BoardgamesSellers = new HashSet<BoardgameSeller>();
       }

       [Key]
       public int Id { get; set; }

       [Required]
       public string Name { get; set; }

       [Required]
       public string Address { get; set; }

       [Required]
       public string Country { get; set; }

       [Required]
       public string Website { get; set; }
       [InverseProperty(nameof(BoardgameSeller.Seller))]
       public virtual ICollection<BoardgameSeller> BoardgamesSellers { get; set; }
}
