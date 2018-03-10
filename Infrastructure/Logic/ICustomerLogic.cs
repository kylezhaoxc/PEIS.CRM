using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface ICustomerLogic
    {
        IEnumerable<OnArcCust> GetLatestCustomerByName(string custName);
        OnArcCust GetLatestCustomerByIdCard(string custName);
        OnArcCust GetLatestCustomerByCustomerId(int custId);

    }
}
