using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers
{
    public class DictionaryHelper
    {
        Dictionary<string, Type> DictNameMapping;
        static DictionaryHelper helper;

        private DictionaryHelper()
        {
            var alldicts = typeof(DictCultrul).Namespace;
        }

        public static DictionaryHelper GetHelper()
        {
            if (helper == null) helper = new DictionaryHelper();
            return helper;
        }
    }
}
