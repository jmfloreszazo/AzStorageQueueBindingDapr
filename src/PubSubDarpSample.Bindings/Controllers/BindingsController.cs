using Microsoft.AspNetCore.Mvc;
using PubSubDaprSample.Contracts;

namespace PubSubDarpSample.Bindings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BindingsController : Controller
    {

        private readonly ILogger<BindingsController> _logger;

        public BindingsController(ILogger<BindingsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/azurequeueinput")]
        public async Task<IActionResult> Bindings () 
        {
            using var streamReader = new StreamReader(Request.Body);
            var body = await streamReader.ReadToEndAsync();
            return new OkResult();
        }
    }
}