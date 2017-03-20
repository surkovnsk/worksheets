using AutoMapper;
using BusinessLogic.Services.Base;
using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO;
using Domain.Entities;

namespace BusinessLogic.Services
{
    public class MethodService
        :IMethodService
    {
        IMethodRepository _methodRepository;
        IMapper _mapper = null;
        public MethodService(IMethodRepository methodRepository, IMapper mapper)
        {
            _methodRepository = methodRepository;
            _mapper = mapper;
        }
        public IEnumerable<MethodDTO> GetMethods()
        {
            var methods = _methodRepository.GetMethods();
            //TODO: здесь может быть ошибка Icollection и IEnumerable
            return _mapper.Map<IEnumerable<Method>, IEnumerable<MethodDTO>>(methods);
        }
    }
}
