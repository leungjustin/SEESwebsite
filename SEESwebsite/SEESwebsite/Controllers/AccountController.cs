using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEESwebsite.Models;

namespace SEESwebsite.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<Employee> userManager;
        private SignInManager<Employee> signInManager;
        public AccountController(UserManager<Employee> userMngr, SignInManager<Employee> signInMngr)
        {
            userManager = userMngr; signInManager = signInMngr;
        }
        // The Register(), LogIn(), and LogOut()methods go here } 

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new Employee 
                {
                    Email = model.EmailAddress,
                    FirstEmployee = model.FirstName,
                    LastName = model.LastName, 
                    PhoneNumber= model.PhoneNumber,
                    Address = model.AddressLine1 + model.AddressLine2,
                    City = model.City,
                    State= model.State,
                    DateOfBirth = model.Dob,
                    EmployeeStatus = model.IsFullTime.ToString()
                };
                user.UserName = user.Email;
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            var model = new LoginVM { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.EmailAddress, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    { return Redirect(model.ReturnUrl); }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }
    }
    
}
