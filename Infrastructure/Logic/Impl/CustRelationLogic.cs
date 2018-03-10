using Infrastructure.Model;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class CustRelationLogic : LogicBase
    {
        public CustRelationLogic(ISqlTableRepository repo) : base(repo)
        {

        }

        public long GetCustIdByArcId(string idCardNumber)
        {
            using (var dbContext = new PEISEntities())
            {
                var target = (from m in dbContext.OnCustRelationCustPEInfo
                              join c in dbContext.OnArcCust
                              on m.IDCardNo equals c.IDCard
                              where m.IDCardNo == idCardNumber
                              select m);
                return target?.FirstOrDefault()?.ID_Customer ?? 0;
            }
        }

        public IEnumerable<long> GetCustIdByName(string custName)
        {
            using (var dbContext = new PEISEntities())
            {
                var target = (from m in dbContext.OnCustRelationCustPEInfo
                              join c in dbContext.OnArcCust
                              on m.IDCardNo equals c.IDCard
                              where c.CustomerName.Contains(custName)
                              select m);
                return target?.Select(p => p.ID_Customer ?? 0);
            }
        }

    }
}
