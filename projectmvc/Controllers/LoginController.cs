using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace projectmvc.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "123" && model.Password == "123") 
                {
                   
                    return RedirectToAction("Index", "Home");
                }

               
                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }
    }

}
