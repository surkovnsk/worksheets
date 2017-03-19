using BusinessLogic.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class ChemicalAgentDTO
        :BaseDTO
    {
        public string NcasCode { get; set; }
        public virtual ICollection<MethodDTO> Methods { get; set; }
    }
}
