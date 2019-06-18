using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    public class TestController : Controller
    {
        /*private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }*/
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
