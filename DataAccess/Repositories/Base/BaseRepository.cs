using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class BaseRepository
    {
        protected WorkSheetsDbContext _context;

        public BaseRepository(WorkSheetsDbContext context)
        {
            _context = context;
        }

    }
}
