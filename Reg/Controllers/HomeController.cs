using Microsoft.AspNetCore.Mvc;

namespace Reg.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}