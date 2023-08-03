using FineTable.Application.DTO.Request;
using FineTable.Application.Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineTable.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FineCollectionController : ControllerBase
    {
        private readonly IFineCollectionManager _manager;

        public FineCollectionController(IFineCollectionManager manager)
        { 
            _manager = manager; 
        }

        [HttpPost]
        public async Task<bool> AddFineCollection(FineCollectionRequest request)
        { 
            var result = await _manager.AddFineCollection(request);
            return result;
        }
    }
}
