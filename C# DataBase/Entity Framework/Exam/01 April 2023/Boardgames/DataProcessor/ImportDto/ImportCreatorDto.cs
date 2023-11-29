using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
       [XmlType("Creator")]
       public class ImportCreatorDto
       {
              [XmlElement("FirstName")]
              public string FirstName { get; set; }
              [XmlElement("LastName")]
              public string LastName { get; set; }

              public ICollection<ImportCreatorBoardgameDto> Boardgames { get;}
       }
}
