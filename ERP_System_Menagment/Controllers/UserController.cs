using ERP_System_Menagment.Core.Models;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{

    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class UserController : Controller
    {
        private readonly SignInManager<Users> signInManager;
        private readonly UserManager<Users> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private ILogger<UserController> logger;


        public UserController(SignInManager<Users> _signInManager,
            UserManager<Users> _userManager,
            RoleManager<IdentityRole> _roleManager,
            ILogger<UserController> _logger)
        {
            signInManager = _signInManager;
            userManager = _userManager;
            roleManager = _roleManager;
            logger = _logger;
        }


        /// <summary>
        /// LogIn current user and loading model 
        /// </summary>
        /// <returns>model of users data</returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }



        /// <summary>
        /// LogIn user and chech email and password
        /// model is valid
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Redirect to start page of login succssesfuly</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var results = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (results.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }


        /// <summary>
        /// Loads the registration view model
        /// </summary>
        /// <returns>View model registration</returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            return View(model);
        }


        /// <summary>
        /// 
        ///Receives in the registration model checks if it is valid 
        ///creates a user after successful 
        ///registration redirects them to the Login page
        /// </summary>
        /// <param name="Register model"></param>
        /// <returns>Redirect to login page</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string first = model.FirstName;
            string last = model.LastName;
            string email = model.Email;

            var user = new Users()
            {
                UserName = email,
                FirstName = first,
                LastName = last,
                Email = email,
                EmailConfirmed = true
            };

            var registerUser = await userManager.CreateAsync(user, model.Password);
            var role = await roleManager.FindByNameAsync("User");


            if (registerUser.Succeeded)
            {
                //await emailSender.SendEmailAsync(user.Email, "Confirm your email",
                //        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode("www.google.com")}'>clicking here</a>.");
                if (role != null)
                {
                    await userManager.AddToRoleAsync(user, role.Name);

                    return RedirectToAction("Login", "User");
                }

            }

            foreach (var error in registerUser.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }


        ///// <summary>
        ///// this method get info for user
        ///// and load page field 
        ///// </summary>
        ///// <returns>
        ///// all info of the current user
        ///// </returns>

        [HttpGet]
        [Authorize]
        public IActionResult ManageUserPage()
        {
            var model = new UserManegePageViewModel();

            var userGet = userManager.GetUserId(HttpContext.User);
            var currerntUsers = userManager.FindByIdAsync(userGet).Result;

            if (currerntUsers != null)
            {
                model = new UserManegePageViewModel()
                {
                    UserName = currerntUsers.UserName,
                    FirstName = currerntUsers.FirstName,
                    LastName = currerntUsers.LastName,
                    Email = currerntUsers.Email,
                };

                return View(model);
            }

            return View(model);
        }


        /// <summary>
        /// Methot get current User information and 
        /// update FirstName,Lastname and Email of on form in View.
        /// second form update user password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>return message to update info from current user </returns>

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageUserPage(UserManegePageViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.ConfirmPassword) && !string.IsNullOrWhiteSpace(model.OldPassword) && !string.IsNullOrWhiteSpace(model.newPassword))
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        var userInfo = userManager.GetUserId(HttpContext.User);
                        var userUpdate = userManager.FindByIdAsync(userInfo).Result;

                        if (userUpdate != null)
                        {
                            var result = await userManager.ChangePasswordAsync(userUpdate, model.OldPassword, model.newPassword);
                            if (result.Succeeded)
                            {
                                ViewBag.Message = $"{userUpdate.UserName}  Your password cuccessfully!";
                                return RedirectToAction("Index", "Home");
                            }

                            ModelState.AddModelError("", "Your new password not corectly");
                        }

                    }
                    catch (ArgumentException ae)
                    {
                        throw new ArgumentException("Not found current User", ae.Message);
                    }

                    return View(model);
                }
            }
            if (!string.IsNullOrWhiteSpace(model.FirstName) || !string.IsNullOrWhiteSpace(model.UserName)
                || !string.IsNullOrWhiteSpace(model.LastName) || !string.IsNullOrWhiteSpace(model.Email))
            {

                if (ModelState.IsValid)
                {
                    try
                    {
                        var userId = userManager.GetUserId(HttpContext.User);
                        var user = userManager.FindByIdAsync(userId).Result;

                        if (!string.IsNullOrEmpty(model.UserName))
                        {
                            user.UserName = model.UserName;
                        }
                        if (!string.IsNullOrEmpty(model.FirstName))
                        {
                            user.FirstName = model.FirstName;
                        }
                        if (!string.IsNullOrEmpty(model.LastName))
                        {
                            user.LastName = model.LastName;
                        }
                        if (!string.IsNullOrEmpty(model.Email))
                        {
                            user.Email = model.Email;
                        }

                        await userManager.UpdateAsync(user);
                    }
                    catch (ArgumentException ae)
                    {
                        throw new ArgumentException("Not found current User", ae.Message);
                    }
                }
            }

            ViewBag.Message = "Your information is upadeted.";
            return View(model);
        }


        /// <summary>
        /// Log out current user
        /// </summary>
        /// <returns>redirect to index page</returns>
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
