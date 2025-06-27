using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyBackend.Contracts.ServiceContracts.GetInterface;
using System.Diagnostics.Contracts;

namespace PharmacyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly IGetServiceContracts _getService;

        public GetController(IGetServiceContracts getService)
        {
            _getService = getService;
        }


    }
}
