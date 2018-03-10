using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ISqlTableRepository
    {
        bool Update<T>(T t) where T : class;
        bool Insert<T>(T t) where T : class;
        T Load<T>(Expression<Func<T, bool>> whereLambda) where T : class;
        List<T> LoadAll<T>(Expression<Func<T, bool>> whereLambda) where T : class;
    }
}
