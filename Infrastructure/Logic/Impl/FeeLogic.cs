using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class FeeLogic : LogicBase, IFeeLogic
    {
        public FeeLogic(ISqlTableRepository repository) : base(repository)
        {
        }

        public IEnumerable<OnCustFee> GetFeeDetailForCustomerId(int customerId)
        {
            return _tableRepository.LoadAll<OnCustFee>(p => p.ID_Customer == customerId);
        }
    }
}
