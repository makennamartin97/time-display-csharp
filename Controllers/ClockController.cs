using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace timedisplay.Controllers
{
    public class ClockController : Controller
    {
        // requests
        // localhost:5000/
        [Route("")]
        [HttpGet]
        public IActionResult Clock()
        {
            //Views/Clock/index.cshtml
            return View("index");
        }
    }
}