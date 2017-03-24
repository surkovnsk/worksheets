using AutoMapper;
using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSheets.Models;

namespace WorkSheets.Infrastructure.Mapping
{
    public class MethodViewProfile
        :Profile
    {
        public MethodViewProfile()
        {
            CreateMap<MethodDTO, MethodViewModel>();

            CreateMap<MethodViewModel, MethodDTO>();
        }
    }
}