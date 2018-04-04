using Infrastructure.Logic;
using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class ConclusionLogic : LogicBase, IConclusionLogic
    {
        public ConclusionLogic(ISqlTableRepository repository) : base(repository)
        {
        }

        public IEnumerable<OnCustConclusion> GetConclusionsByIdCard(string id)
        {
            var arcids = _tableRepository.LoadAll<OnCustRelationCustPEInfo>(p => p.IDCardNo == id).Select(p => p.ID_Customer ?? 0);
            return arcids.Select(p => _tableRepository.Load<OnCustConclusion>(c => c.ID_Customer == p));
        }

        public OnCustConclusion GetConclusionDetailsById(int conclusionId)
        {
            return _tableRepository.Load<OnCustConclusion>(p => p.ID_CustConclusion == conclusionId);
        }

        public OnCustConclusion GetConclusionsByName(string name)
        {
            var ArcIdCustomers = _tableRepository.LoadAll<OnArcCust>(p => p.CustomerName == name).Select(p => p.ID_ArcCustomer).ToList();
            var arcids = _tableRepository.LoadAll<OnCustRelationCustPEInfo>(p => ArcIdCustomers.Contains(p.ID_ArcCustomer ?? 0)).Select(p => p.ID_Customer ?? 0).ToList();

            return _tableRepository.Load<OnCustConclusion>(p => arcids.Contains(p.ID_Customer ?? 0));
        }
    }
}
