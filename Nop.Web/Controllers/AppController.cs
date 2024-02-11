using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers;

[AutoValidateAntiforgeryToken]
public class AppController : Controller
{
    public IActionResult Index()
    {
        return File()
    }
}
