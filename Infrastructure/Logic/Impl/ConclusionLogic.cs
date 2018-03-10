using Infrastructure.Logic;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class ConclusionLogic : IConclusionLogic
    {
        ISqlTableRepository _tableRepository;
        public ConclusionLogic(ISqlTableRepository repository)
        {
            _tableRepository = repository;
        }
    }
}
