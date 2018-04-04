using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface IExamLogic
    {
        List<OnCustPhysicalExamInfo> GetAllPhysicalExamByIdCard(string idCard);
        List<OnCustReportManage> GetAllReportsByCustId(int custId);
    }
}
