using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using WebApplication.DataAccess.Context;
using WebApplication.DataAccess.Interface;
using WebApplication.DataAccess.Repositories;

namespace WebApplication.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IEnumRepository _enumRepository;
        protected readonly WebApplicationContext _context;
        private bool disposed = false;
        public UnitOfWork(WebApplicationContext context)
        {
            _context = context;
        }

        public IEnumRepository EnumRepository
        {
            get 
            {
                if (_enumRepository == null)
                    _enumRepository = new EnumRepository(_context);
                return _enumRepository; 
            }
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return  await _context.Database.BeginTransactionAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Detach(object entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
                _context?.Dispose();
            this.disposed = true;
        }
    }
}
