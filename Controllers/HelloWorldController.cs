using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController:ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        IHelloWorldService _helloWorldService;
        TareasContext dbcontext;
        public HelloWorldController(ILogger<HelloWorldController> logger,IHelloWorldService helloWorldService,TareasContext db)
        {
            _logger=logger;
            _helloWorldService=helloWorldService;
            dbcontext = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Ingresa al metodo get");
            return Ok(_helloWorldService.GetHelloWorld());
        }

    [HttpGet]
    [Route("createdb")]
    public IActionResult CreateDatabase()
    {
        dbcontext.Database.EnsureCreated();

        return Ok();
    }
    }
}