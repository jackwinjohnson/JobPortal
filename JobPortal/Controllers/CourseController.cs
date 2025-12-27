using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllAsync()
        {
            var courses = await _courseService.GetAllAsync();
            return Ok(courses);
        }

    }
}
