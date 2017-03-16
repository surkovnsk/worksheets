using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Entities

{
    public class Measurement
    {

        public int Id { get; set; }

        public ICollection<Variable> ListOfVariables { get; set; }
        public float Result { get; set; }
        public Method Method { get; set; }
        public ChemicalAgent ChemicalAgent { get; set; }

    }
}