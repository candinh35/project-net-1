using Microsoft.AspNetCore.Mvc;

namespace MyMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
