using BusinessLogic.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class MethodDTO
        :BaseDTO
    {
        public int? FormulatemplateId { get; set; }
        public FormulaTemplateDTO FormulaTemplate { get; set; }

    }
}
