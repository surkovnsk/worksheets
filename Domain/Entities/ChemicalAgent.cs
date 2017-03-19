using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;

namespace Domain.Entities
{
    [Table("ChemicalAgents")]
   public class ChemicalAgent:
        BaseDBEntity
    {
        public string NcasCode { get; set; }

        public virtual ICollection<Method> Methods { get; set; }
    }
}
