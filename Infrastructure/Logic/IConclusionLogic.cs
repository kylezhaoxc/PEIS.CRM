using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface IConclusionLogic
    {
        IEnumerable<OnCustConclusion> GetConclusionsByIdCard(string id);

        OnCustConclusion GetConclusionDetailsById(int conclusionId);

        OnCustConclusion GetConclusionsByName(string name);
    }
}
