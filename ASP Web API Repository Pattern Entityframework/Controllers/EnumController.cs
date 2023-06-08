using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Enum = WebApplication.DataAccess.Model.Enum;
using WebApplication.Services.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        private readonly IEnumService _enumService;
        public EnumController(IEnumService enumService)
        {
            _enumService = enumService;
        }

        [Route("all"),HttpGet]
        public IEnumerable<Enum> GetAll()
        {
            return _enumService.GetAllEnums();
        }
    }
}
