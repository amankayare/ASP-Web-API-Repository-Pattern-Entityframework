using System.Collections.Generic;
using System.Linq;
using WebApplication.DataAccess.Interface;
using WebApplication.DataAccess.Model;
using WebApplication.Services.Interfaces;

namespace WebApplication.Services
{
    public class EnumService : IEnumService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EnumService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Enum> GetAllEnums()
        {
            return  _unitOfWork.EnumRepository.GetAll().ToList();
        }
    }
}
