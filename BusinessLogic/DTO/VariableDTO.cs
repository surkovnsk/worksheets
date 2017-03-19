using BusinessLogic.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class VariableDTO
        :BaseDTO
    {
        public string Code { get; set; }
        public int? FormulaId { get; set; }
        public string Description { get; set; }
        public FormulaTemplateDTO Formula { get; set; }
    }
}
