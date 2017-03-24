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
    public class MethodProfile
        : Profile
    {
        public MethodProfile()
        {
            CreateMap<Method, MethodDTO>();

            CreateMap<MethodDTO, Method>();
        }
    }
}
