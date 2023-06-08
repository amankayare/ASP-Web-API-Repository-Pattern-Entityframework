using WebApplication.DataAccess.Context;
using WebApplication.DataAccess.Interface;
using WebApplication.DataAccess.Model;

namespace WebApplication.DataAccess.Repositories
{
    public class EnumRepository : Repository<Enum>,IEnumRepository
    {
        public EnumRepository(WebApplicationContext context) : base(context) { }
    }
}
