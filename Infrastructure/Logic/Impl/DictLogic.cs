using Infrastructure.Helpers;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic.Impl
{
    public class DictLogic : LogicBase, IDictLogic
    {
        public DictLogic(ISqlTableRepository repository) : base(repository)
        {
            _tableRepository = repository;
        }

        public void AddDictItem(string dictName, string key, string value)
        {
            var helper = DictionaryHelper.GetHelper();
            var DictType = helper.GetTypeFromName(dictName);
            var obj = Activator.CreateInstance(DictType);
            var nameProperty = DictType.GetProperties().Where(p => p.Name.EndsWith("Name")).FirstOrDefault();
            var inputCodeProperty = DictType.GetProperties().Where(p => p.Name == "InputCode").FirstOrDefault();
            nameProperty.SetValue(obj, key);
            inputCodeProperty.SetValue(obj, value);

            _tableRepository.GetType().GetMethod("Insert").MakeGenericMethod(DictType).Invoke(_tableRepository, new[] { obj });
        }

        public dynamic ListDictItem(string dictName)
        {
            var helper = DictionaryHelper.GetHelper();
            var DictType = helper.GetTypeFromName(dictName);
            return _tableRepository.GetType().GetMethod("LoadAllItems").MakeGenericMethod(DictType).Invoke(_tableRepository, null);
        }

    }
}
