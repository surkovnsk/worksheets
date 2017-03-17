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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int MethodId { get; set; }

        [Required]
        public int ChemicalAgentId { get; set; }

        public virtual ICollection<Variable> ListOfVariables { get; set; }
        public float Result { get; set; }

        [ForeignKey("MethodId")]
        public virtual Method Method { get; set; }

        [ForeignKey("ChemicalAgentId")]
        public virtual ChemicalAgent ChemicalAgent { get; set; }

    }
}