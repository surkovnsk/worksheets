using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Context;
using AutoMapper;
using BusinessLogic.Services.Base;
using WorkSheets.Models;
using BusinessLogic.DTO;

namespace WorkSheets.Controllers
{
    public class MethodController : Controller
    {

        IMethodService _methodService = null;
        IMapper _mapper = null;

        public MethodController(IMethodService methodService, IMapper mapper)
        {
            _methodService = methodService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
          //  var context = new WorkSheetsDbContext();
         //   var methods = context.ChemicalAgents.ToArray();
            return View(GetMethods());
        }


        public IEnumerable<MethodViewModel> GetMethods()
        {
            var m = _methodService.GetMethods();
            return _mapper.Map<IEnumerable<MethodDTO>, IEnumerable<MethodViewModel>>(m);
        }

    }
}