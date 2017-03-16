using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace DataAccess.Context
{
    public class WorkSheetsDbContext:
        DbContext
    {
        public WorkSheetsDbContext():base("LocalDBConnection")
        {

        }
        public virtual DbSet<ChemicalAgent> ChemicalAgents { get; set; }
        public virtual DbSet<FormulaTemplate> FormulaTemplates { get; set; }
        public virtual DbSet<WorkSheet> WorkSheets { get; set; }
        public virtual DbSet<Method> Methods { get; set; }
        public virtual DbSet<Variable> Variables { get; set; }
    }
}
