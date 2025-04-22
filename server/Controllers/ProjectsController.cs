using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase{
        [HttpGet]
        public IActionResult Get(){
            var projects = new[]{
                new {Title = "Portfolio Site", Tech = "Angular + .NET Core"},
                new {Title = "E-Commerce Demo", Tech = "Angular + SQL Server"}
            };
            return Ok(projects);
        }
    }
}