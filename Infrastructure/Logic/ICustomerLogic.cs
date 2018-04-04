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
        IEnumerable<OnArcCust> GetAllCustomerByName(string custName);
        OnArcCust GetLatestCustomerByIdCard(string custName);
        OnArcCust GetLatestCustomerByCustomerId(int custId);
        IEnumerable<OnArcCust> GetLowFreqCustomers(int size = 20);
        IEnumerable<OnCustPhysicalExamInfo> GetFinishedExam(DateTime targetdate);
        IEnumerable<OnCustPhysicalExamInfo> GetUnfinishedExam(DateTime targetdate);
    }
}
