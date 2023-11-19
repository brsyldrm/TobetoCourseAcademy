using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseEducatorController : ControllerBase
    {
        ICourseEducatorService _courseEducatorService;

        public CourseEducatorController(ICourseEducatorService courseEducatorService)
        {
            _courseEducatorService = courseEducatorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseEducatorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("get")]
        public IActionResult GetById(int id)
        {
            var result = _courseEducatorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CourseEducator courseEducator)
        {
            var result = _courseEducatorService.Add(courseEducator);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
