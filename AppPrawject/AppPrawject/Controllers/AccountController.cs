using AppPrawject.Domain.Model;
using AppPrawject.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrawject.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;


        }

        [HttpGet]
        public IActionResult Register()
        {

            RedirectUserWhenAlreadyLoggedIn();

            var roles = _roleManager.Roles.ToList();

            var vm = new RegisterViewModel
            {
                Roles = roles
            };
            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterViewModel vm)  //vm=ViewModel

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

                if (result.Succeeded)//new user got created

                {
                    //assign the selected role to the newly created user(customer or technician)

                    result = await _userManager.AddToRoleAsync(newUser, "Customer");

                    if (result.Succeeded) //new user got assigned to a role
                    {
                        //we can login the user 
                        await _signInManager.SignInAsync(newUser, false);

                        //redirect
                        if (vm.Role == "Provider")
                        {
                            return RedirectToAction("Index", "Provider");

                        }

                        return RedirectToAction("Index", "Customer");
                    }

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

            //repopulate the Roles to generate the dropdown
            var roles = _roleManager.Roles.ToList();
            vm.Roles = roles;
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            RedirectUserWhenAlreadyLoggedIn();

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect");
                }
            }

            return View(vm);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }



        private IActionResult RedirectUserWhenAlreadyLoggedIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return null;
        }


    }


}