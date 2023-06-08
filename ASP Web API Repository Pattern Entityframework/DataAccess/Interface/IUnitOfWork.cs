using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace WebApplication.DataAccess.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        public IEnumRepository EnumRepository { get; }
        public Task<IDbContextTransaction> BeginTransactionAsync();
        public IDbContextTransaction BeginTransaction();
        public Task<int> SaveAsync();
        public void Save();
        public void Detach(object entity);
    }
}
