using IKProje.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IKProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    UserName = registerViewModel.SicilNo,
                };

                var identityResult = await userManager.CreateAsync(identityUser, registerViewModel.Password);

                if (identityResult.Succeeded)
                {
                    var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "User");
                    if (roleIdentityResult.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                }

                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var signInResult = await signInManager.PasswordSignInAsync(loginViewModel.SicilNo,
                loginViewModel.Password, false, false);
            if (signInResult != null && signInResult.Succeeded)
            {
                return RedirectToAction("List", "Personel");

            }
            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
            return View(loginViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("List", "Personel");
        }


   

    }
}



  