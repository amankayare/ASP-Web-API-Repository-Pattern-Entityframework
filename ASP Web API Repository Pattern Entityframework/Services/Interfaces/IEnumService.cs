using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DataAccess.Model;

namespace WebApplication.Services.Interfaces
{
    public interface IEnumService
    {
        List<Enum> GetAllEnums();
    }
}
