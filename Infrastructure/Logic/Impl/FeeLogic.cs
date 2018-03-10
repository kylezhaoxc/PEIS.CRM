using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class FeeLogic : IFeeLogic
    {
        ISqlTableRepository _tableRepository;
        public FeeLogic(ISqlTableRepository repository)
        {
            _tableRepository = repository;
        }
    }
}
