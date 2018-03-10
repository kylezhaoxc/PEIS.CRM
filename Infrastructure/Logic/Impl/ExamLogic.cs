using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class ExamLogic : LogicBase
    {
        public ExamLogic(ISqlTableRepository repository) : base(repository)
        {
        }

        
    }
}
