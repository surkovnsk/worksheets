using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("WorkSheets")]
    public class WorkSheet
        :Base.BaseDBEntity
    {
        public FormulaTemplate FormulaTemplate { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public ICollection<Measurement> ListOfMeasurements { get; set; }


    }
}
