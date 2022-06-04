using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    //[ApiController]
    [Route("api/[controller]")]
    public class TareaController:ControllerBase
    {
        ITareas tareaServices;
        public TareaController(ITareas tareasService)
        {
            tareaServices=tareasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tareaServices.Get());
        }
    }
}