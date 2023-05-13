using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Areas.Admin.Models;
using Newtonsoft.Json;
using MyMvcProject.Areas.Admin.Data;

namespace MyMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost] // POST khi submit form
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // trả về trạng thái lỗi
            }

            Login acc = _context.Users.FirstOrDefault(a => a.Email.Equals(model.Email) && a.Password.Equals(model.Password));
            if (acc != null)
            {
                HttpContext.Session.SetString("AdminLogin", JsonConvert.SerializeObject(acc));
                return RedirectToAction("Index", "Dashboard");
            }

            ModelState.AddModelError("Email", "Tài khoản hoac mật khẩu không chính xác");
            // sẽ xử lý logic phần đăng nhập tại đây
            return View(model); // trả về trạng thái lỗi
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin");
            return RedirectToAction("Login");
        }
    }
}
