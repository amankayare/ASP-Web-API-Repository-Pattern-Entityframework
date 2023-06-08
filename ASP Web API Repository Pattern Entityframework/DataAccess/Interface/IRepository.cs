using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebApplication.DataAccess.Interface
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        List<T> AddRange(List<T> entities);
        T GetById(object id);
        T Update(T entity);
        List<T>UpdateRange(List<T> entities);
        void Delete(T entity);
        void DeleteRange(List<T> entities);
        IQueryable<T> GetAll();
        IEnumerable<T> GetFromRawSql(string query, params object[] parameters);
        IEnumerable<DTO> ExecuteProcedure<DTO>(string storedProcedureName, string[] parameterNames, object[] parameterValues, IDbTransaction transaction = null) where DTO : new();
        IEnumerable<DTO> ExecuteProcedure<DTO>(string storedProcedureName, string[] parameterNames, object[] parameterValues, string[] outParameters, object[] outParametersValues,out List<object> outSQLParameterValues, IDbTransaction transaction = null) where DTO : new();
        object ExecuteProcedure(string storedProcedureName, string[] parameterNames, object[] parameterValues);
        bool ValidateOrderByColumn<T>(string orderByColumn);
        DataTable ParseDataTable(List<string> tpaget);
    }
}
