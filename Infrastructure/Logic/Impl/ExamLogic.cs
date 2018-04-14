using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class ExamLogic : LogicBase, IExamLogic
    {
        public ExamLogic(ISqlTableRepository repository) : base(repository)
        {
        }

        public List<OnCustPhysicalExamInfo> GetAllPhysicalExamByIdCard(string idCard)
        {
            return _tableRepository.LoadAll<OnCustPhysicalExamInfo>(p => p.IDCard == idCard);
        }

        public List<OnCustReportManage> GetAllReportsByCustId(long custId)
        {
            return _tableRepository.LoadAll<OnCustReportManage>(p => p.ID_Customer == custId);
        }
    }
}
