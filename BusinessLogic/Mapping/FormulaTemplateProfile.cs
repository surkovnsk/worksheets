using AutoMapper;
using BusinessLogic.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapping
{
    public class FormulaTemplateProfile
        : Profile
    {
        public FormulaTemplateProfile()
        {
            CreateMap<FormulaTemplate, FormulaTemplateDTO>();
            CreateMap<FormulaTemplateDTO, FormulaTemplate>();
        }
    }
}
