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

        public IEnumerable<OnArcCust> GetAllCustomerByName(string custName)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.CustomerName.Contains(custName))
                .OrderByDescending(p => p.FirstDatePE);
        }

        public OnArcCust GetLatestCustomerByIdCard(string idCard)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.IDCard == idCard)
                .OrderByDescending(p => p.FirstDatePE).FirstOrDefault();
        }

        public OnArcCust GetLatestCustomerByCustomerId(int custId)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => p.ID_ArcCustomer == custId)
               .OrderByDescending(p => p.FirstDatePE).FirstOrDefault();
        }

        public IEnumerable<OnArcCust> GetLowFreqCustomers(int size = 20)
        {
            return _tableRepository.LoadAll<OnArcCust>(p => true)
                .OrderBy(p => p.LatestDatePE).Take(size);
        }

        public IEnumerable<OnCustPhysicalExamInfo> GetFinishedExam(DateTime targetdate)
        {
            return _tableRepository.LoadAll<OnCustPhysicalExamInfo>(p => p.GuideSheetReturnedDate.Value.Day == targetdate.Day && p.Is_Checked == true);
        }

        public IEnumerable<OnCustPhysicalExamInfo> GetUnfinishedExam(DateTime targetdate)
        {
            return _tableRepository.LoadAll<OnCustPhysicalExamInfo>(p => p.GuideSheetReturnedDate.Value.Day == targetdate.Day && p.Is_Checked == false);
        }

        
    }
}
