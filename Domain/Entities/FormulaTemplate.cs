using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("FormulaTemplates")]
    public class FormulaTemplate : Base.BaseDBEntity 
    {
        [Column(TypeName = "varchar")]
        [StringLength(1024)]
        public string Formula { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1024)]
        public string ResultDescription { get; set; }

        public ICollection<Variable> ListOfVariables { get; set; }
    }
}
