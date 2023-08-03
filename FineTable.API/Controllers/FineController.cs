using FineTable.Application.DTO.Request;
using FineTable.Application.Manager.Interface;
using FineTable.Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineTable.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FineController : ControllerBase
    {
        private readonly IFineManager _manager;
        public FineController(IFineManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<IActionResult> GetFine()
        {
            var result = await _manager.GetFine();
            if (result.Status == StatusType.Success) 
            {
                return Ok(result.Data);
            }
            return NotFound(result.Message);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFineById(int id)
        {
            var result = await _manager.GetFineById(id);
            if(result.Status == StatusType.Success)
            {
                return Ok(result.Data);
            }
            return NotFound(result.Message);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFineStatus(int id, FineRequest request)
        {
            if(id!= request.Id)
            {
                return BadRequest("Invalid Fine ID");
            }
            var result = await _manager.UpdateFineStatus(request);

            if(result.Status==StatusType.Success)
            {
                return Ok(result.Message);
            }
            return NotFound(result.Message);
        }
    }
}
