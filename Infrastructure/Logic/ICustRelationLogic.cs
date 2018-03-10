using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface ICustRelationLogic
    {
        long GetCustIdByArcId(string idCardNumber);
        IEnumerable<long> GetCustIdByName(string custName);
    }
}
