using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class DictLogic : IDictLogic
    {
        ISqlTableRepository _tableRepository;
        public DictLogic(ISqlTableRepository repository)
        {
            _tableRepository = repository;
        }
    }
}
