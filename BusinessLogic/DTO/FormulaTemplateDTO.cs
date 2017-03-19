using BusinessLogic.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
   public class FormulaTemplateDTO
        :BaseDTO
    {
        public string Formula { get; set; }
        public string ResultDescription { get; set; }
        public ICollection<VariableDTO> ListOfVariables { get; set; }
    }
}
