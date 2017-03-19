using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class MethodRepository :
        IMethodRepository
    {
        WorkSheetsDbContext context;
        public MethodRepository(WorkSheetsDbContext context)
        {
            this.context = context;
        }
        public ICollection<Method> GetMethods()
        {
            return context.Methods.ToArray();
        }
    }
}
