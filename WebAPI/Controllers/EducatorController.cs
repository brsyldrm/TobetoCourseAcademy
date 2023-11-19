using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducatorController : ControllerBase
    {
        IEducatorService _educatorService;

        public EducatorController(IEducatorService educatorService)
        {
            _educatorService = educatorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _educatorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("get")]
        public IActionResult GetById(int id)
        {
            var result = _educatorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Educator educator)
        {
            var result = _educatorService.Add(educator);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
