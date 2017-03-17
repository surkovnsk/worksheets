using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Methods")]
    public class Method
        :Base.BaseDBEntity
    {
        public int? FormulatemplateId { get; set; }

        [ForeignKey("FormulatemplateId")]
        public virtual FormulaTemplate FormulaTemplate { get; set; }
    }
}
