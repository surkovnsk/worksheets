﻿using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Base
{
    public interface IMethodService
    {
        IEnumerable<MethodDTO> GetMethods();
    }
}
