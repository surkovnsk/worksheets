﻿using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Variables")]
    public class Variable
        :BaseDBEntity
    {
        [Column(TypeName = "varchar")]
        [StringLength(2)]
        public string Code { get; set; }

        public int? FormulaId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1024)]
        public string Description { get; set; }

        [ForeignKey("FormulaId")]
        public virtual FormulaTemplate Formula { get; set; }
    }
}
