using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Claims;
using testMVC.Models;
using testMVC.ViewModel;

namespace testMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            ApplicationUser user = new ApplicationUser();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveRegister(RegisterViewModel UserViewModel)
        {
            if(ModelState.IsValid)
            {
                //Mappping
                ApplicationUser appUser = new ApplicationUser();
                appUser.UserName = UserViewModel.UserName;
                appUser.Address = UserViewModel.Address;
                appUser.PasswordHash = UserViewModel.Password;
                //save user in database
                IdentityResult result= await userManager.CreateAsync(appUser,UserViewModel.Password );
                if (result.Succeeded)
                {

                    //assign to role
                    await userManager.AddToRoleAsync(appUser, "Admin");
                    //create cookie
                    //SignInManager<ApplicationUser> signInManager = new SignInManager<ApplicationUser>();
                    await signInManager.SignInAsync(appUser, isPersistent: false);
                    return RedirectToAction("Index", "Department");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                //use service to make mappping(usermanager)
                //UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>();
            }
            return View("Register", UserViewModel);
        }
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public async Task<IActionResult> SaveLogin(LoginUserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                //check found 
                ApplicationUser appUser= 
                    await userManager.FindByNameAsync(userViewModel.Name);
                if (appUser != null)
                {
                    bool found= await userManager.CheckPasswordAsync(appUser,userViewModel.Password);
                    if (found)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("UserAddress",appUser.Address));
                        await signInManager.SignInWithClaimsAsync(appUser, userViewModel.RememberMe, claims);
                        //await signInManager.SignInAsync(appUser, userViewModel.RememberMe);
                        return RedirectToAction("Index", "Department");
                    }
                }
                ModelState.AddModelError("", "Username or pass wrong");
                //create cookie 
            }
            return View("Login",userViewModel);
        }
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return View("Register");
        }
    }
}
