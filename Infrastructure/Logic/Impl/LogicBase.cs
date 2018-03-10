using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class LogicBase
    {
        protected ISqlTableRepository _tableRepository;

        public LogicBase(ISqlTableRepository repository)
        {
            _tableRepository = repository;
        }

    }
}
