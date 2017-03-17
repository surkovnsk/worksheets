using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("ChemicalAgents")]
   public class ChemicalAgent:
        Base.BaseDBEntity
    {
        public string NcasCode { get; set; }

        public virtual ICollection<Method> Methods { get; set; }
    }
}
