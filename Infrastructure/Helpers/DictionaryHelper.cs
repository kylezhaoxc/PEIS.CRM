using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            DictNameMapping = new Dictionary<string, Type>();
            var asm = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.FullName.StartsWith("Infrastructure.Model.Dict"));
            asm.ToList().ForEach(p => DictNameMapping.Add(p.Name.Substring(4), p));
        }

        public static DictionaryHelper GetHelper()
        {
            if (helper == null) helper = new DictionaryHelper();
            return helper;
        }

        public Type GetTypeFromName(string typeName)
        {
            if (DictNameMapping.ContainsKey(typeName))
            {
                return DictNameMapping[typeName];
            }
            else
            {
                return null;
            }
        }
    }
}
