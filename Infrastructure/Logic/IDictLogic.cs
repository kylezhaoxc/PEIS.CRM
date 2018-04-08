using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface IDictLogic
    {
        void AddDictItem(string dictName, string key, string value);

        dynamic ListDictItem(string dictName);
    }
}
