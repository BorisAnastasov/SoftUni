using Boardgames.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
       [XmlType("Boardgame")]
       public class ImportCreatorBoardgameDto
       {
              [XmlElement("Name")]
              public string Name { get; set; }
              [XmlElement("Rating")]
              public double Rating { get; set; }
              [XmlElement("YearPublished")]
              public int YearPublished { get; set; }
              [XmlElement("CategoryType")]
              public CategoryTypes CategoryType { get; set; }
              [XmlElement("Mechanics")]
              public string Mechanics { get; set; }
       }
}
