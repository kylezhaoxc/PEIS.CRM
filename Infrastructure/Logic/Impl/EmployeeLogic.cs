using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class EmployeeLogic : IEmployeeLogic
    {
        ISqlTableRepository _tableRepository;
        public EmployeeLogic(ISqlTableRepository repository)
        {
            _tableRepository = repository;
        }
    }
}
