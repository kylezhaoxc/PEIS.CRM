using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SqlTableRepository : ISqlTableRepository
    {
        public bool Update<T>(T t) where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                dbContext.Entry(t).State = System.Data.Entity.EntityState.Modified;
                if (dbContext.SaveChanges() != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove<T>(T t) where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                dbContext.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                if (dbContext.SaveChanges() != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Insert<T>(T t) where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                dbContext.Set<T>().Add(t);
                if (dbContext.SaveChanges() != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public T Load<T>(Expression<Func<T, bool>> whereLambda) where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                return dbContext.Set<T>().Where(whereLambda).FirstOrDefault();
            }
        }

        public List<T> LoadAll<T>(Expression<Func<T, bool>> whereLambda) where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                return dbContext.Set<T>().Where(whereLambda).ToList();
            }
        }

        public List<T> LoadAllItems<T>() where T : class
        {
            using (var dbContext = new PEISEntities())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public static string DbEntityValidationExceptionToString(DbEntityValidationException ex)
        {
            var validationErrors = DbEntityValidationResultToString(ex);
            var exceptionMessage = string.Format("DbEntityValidationExceptionToString - {0}{1}Validation errors:{1}{2}", ex, Environment.NewLine, validationErrors);
            return exceptionMessage;
        }


        public static string DbEntityValidationResultToString(DbEntityValidationException ex)
        {
            return ex.EntityValidationErrors
                    .Select(dbEntityValidationResult => DbValidationErrorsToString(dbEntityValidationResult, dbEntityValidationResult.ValidationErrors))
                    .Aggregate(string.Empty, (current, next) => string.Format("DbEntityValidationResultToString - {0}{1}{2}", current, Environment.NewLine, next));
        }

        public static string DbValidationErrorsToString(DbEntityValidationResult dbEntityValidationResult, IEnumerable<DbValidationError> dbValidationErrors)
        {
            var entityName = string.Format("[{0}]", dbEntityValidationResult.Entry.Entity.GetType().Name);
            const string indentation = "\t - ";
            var aggregatedValidationErrorMessages = dbValidationErrors.Select(error => string.Format("[{0} - {1}]", error.PropertyName, error.ErrorMessage))
                                                   .Aggregate(string.Empty, (current, validationErrorMessage) => current + (Environment.NewLine + indentation + validationErrorMessage));
            return string.Format("DbValidationErrorsToString - {0}{1}", entityName, aggregatedValidationErrorMessages);
        }
    }
}
