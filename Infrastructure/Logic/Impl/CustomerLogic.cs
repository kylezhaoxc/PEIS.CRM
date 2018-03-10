using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class CustomerLogic : LogicBase, ICustomerLogic
    {

        public CustomerLogic(ISqlTableRepository repository) : base(repository)
        {
        }

        public IEnumerable<OnArcCust> GetLatestCustomerByName(string custName)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.CustomerName.Contains(custName))
                .OrderByDescending(p => p.FirstDatePE);
        }

        public OnArcCust GetLatestCustomerByIdCard(string custName)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.IDCard == custName)
                .OrderByDescending(p => p.FirstDatePE).FirstOrDefault();
        }

        public OnArcCust GetLatestCustomerByCustomerId(int custId)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.ID_ArcCustomer == custId)
               .OrderByDescending(p => p.FirstDatePE).FirstOrDefault();
        }


    }
}
