using AppPrawject.Domain.Model;
using AppPrawject.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppPrawject.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)

        {
            _userManager = userManager;
            _signInManager = signInManager;


        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterViewModel vm)

        {
            //register user
            if (ModelState.IsValid)
            {
                var newUser = new AppUser
                {
                    UserName = vm.Email,
                    NormalizedUserName = vm.Email.ToUpper(),
                    Email = vm.Email,
                    NormalizedEmail = vm.Email.ToUpper()

                };

                var result = await _userManager.CreateAsync(newUser, vm.Password);

                if (result.Succeeded)
                {
                    //new user got created
                    //we can login the user 
                    //send user to the right app page(redirect)
                    await _signInManager.SignInAsync(newUser, false);

                    return RedirectToAction("Index", "Home"); //home/index
                    //return RedirectToAction(nameof(HomeController.Index), nameof(HomeController));
                }

                else
                {
                    //for some reason User was not created
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }


                }


            }
            //sending back the error(s) to the user (register form)
            return View(vm);
        }

    }
}