using DataAccess.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Initializer
{
    public class DbContextInitializer: 
        DropCreateDatabaseAlways<WorkSheetsDbContext>
    {
        protected override void Seed(WorkSheetsDbContext context)
        {
            context.ChemicalAgents.AddRange(new List<ChemicalAgent>
            {
                new ChemicalAgent { Name = "Свинец" }
            });

            context.SaveChanges();

            context.Methods.AddRange(new List<Method>
            {
                new Method { Name = "МУ 1111"}
            });

            context.SaveChanges();
        }
    }
}
