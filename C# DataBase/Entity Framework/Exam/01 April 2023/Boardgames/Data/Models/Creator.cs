using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models;

public class Creator
{
       public Creator()
       {
              Boardgames = new HashSet<Boardgame>();
       }

       [Key]
       public int Id { get; set; }

       [Required]
       public string FirstName { get; set; }

       [Required]
       public string LastName { get; set; }

       [InverseProperty(nameof(Boardgame.Creator))]
       public virtual ICollection<Boardgame> Boardgames { get; set; }
}
