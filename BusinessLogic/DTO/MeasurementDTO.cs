using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO
{
    public class MeasurementDTO
    {
        public int Id { get; set; }
        public int MethodId { get; set; }
        public int ChemicalAgentId { get; set; }
        public ICollection<VariableDTO> ListOfVariables { get; set; }
        public float Result { get; set; }
        public MethodDTO Method { get; set; }
        public ChemicalAgentDTO ChemicalAgent { get; set; }
    }
}
