using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebApplication.DataAccess.Interface;

namespace WebApplication.DataAccess.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _context { get; private set; }
        protected DbSet<T> _dbSet { get; private set; }
        protected Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Add(T entity)
        {
            if(entity != null)
                _dbSet.Add(entity);
            return entity;
        }

        public List<T> AddRange(List<T> entities)
        {
           if(entities != null && entities.Count > 0)
                _dbSet.AddRange(entities);
           return entities;
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            if(entity != null)
                _dbSet.Update(entity);
            return entity;
        }

        public List<T> UpdateRange(List<T> entities)
        {
            if (entities != null && entities.Count > 0)
                _dbSet.UpdateRange(entities);
            return entities;
        }

        public void Delete(T entity)
        {
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void DeleteRange(List<T> entities)
        {
            if (entities != null && entities.Count > 0)
                _dbSet.RemoveRange(entities);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IEnumerable<T> GetFromRawSql(string query, params object[] parameters)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTO> ExecuteProcedure<DTO>(string storedProcedureName, string[] parameterNames, object[] parameterValues, IDbTransaction transaction = null) where DTO : new()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTO> ExecuteProcedure<DTO>(string storedProcedureName, string[] parameterNames, object[] parameterValues, string[] outParameters, object[] outParametersValues, out List<object> outSQLParameterValues, IDbTransaction transaction = null) where DTO : new()
        {
            throw new System.NotImplementedException();
        }

        public object ExecuteProcedure(string storedProcedureName, string[] parameterNames, object[] parameterValues)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateOrderByColumn<T1>(string orderByColumn)
        {
            throw new System.NotImplementedException();
        }

        public DataTable ParseDataTable(List<string> tpaget)
        {
            throw new System.NotImplementedException();
        }
    }
}
