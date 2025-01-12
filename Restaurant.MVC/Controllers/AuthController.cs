using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BL.VM.Auth;
using Restaurant.CORE.Entities;

namespace Restaurant.MVC.Controllers
{
    public class AuthController(UserManager<User> userManager,SignInManager<User> signInManager) : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            User user = new User
            {
                Email = registerVM.Email,
                FullName = registerVM.Fullname,
                UserName = registerVM.Username,
                ProfileImageUrl = "photo.jpg",
                PasswordHash = registerVM.Password
            };
            var result = await userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            User? user = null;  
            if (loginVM.UsernameOrEmail.Contains("@"))
            {
                user = await userManager.FindByEmailAsync(loginVM.UsernameOrEmail);
            }
            else
            {
                user = await userManager.FindByNameAsync(loginVM.UsernameOrEmail);
            }
            if(user == null)
            {
                ModelState.AddModelError("", "Username or password is wrong!");
                return View();
            }
            var result = await signInManager.PasswordSignInAsync(user,loginVM.Password,loginVM.RememberMe,true);
            if (!result.Succeeded)
            {
                if (result.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Username or password is wrong!");
                }
                return View();
            }
            return RedirectToAction("Index","Admin");

        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }
    }
}
