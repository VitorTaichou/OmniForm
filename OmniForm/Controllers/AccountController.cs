using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OmniForm.Data.Model;
using OmniForm.Models.Account;

namespace OmniForm.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CustomerUser> userManager;
        private readonly SignInManager<CustomerUser> signInManager;

        public AccountController(UserManager<CustomerUser> userManager, SignInManager<CustomerUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(CustomerUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                //Creating phone number list
                List<PhoneNumber> phoneList = new List<PhoneNumber>()
                {
                    new PhoneNumber()
                    {
                        Number = model.PhoneNumber1
                    }
                };
                //Checking for second phone
                if (model.PhoneNumber2 != null)
                {
                    phoneList.Add(new PhoneNumber()
                    {
                        Number = model.PhoneNumber2
                    });
                }

                //Creating User
                var user = new CustomerUser()
                {
                    FullName = model.FullName,
                    Cpf = model.Cpf,
                    Rg = model.Rg,
                    Sex = model.Sex,
                    Birthday = model.Birthday,
                    Cep = model.Cep,
                    Street = model.Street,
                    Number = model.Number,
                    Neighborhood = model.Neighborhood,
                    Complement = model.Complement,
                    City = model.City,
                    State = model.State,
                    Email = model.Email,
                    UserName = model.Email,
                    PhoneNumbers = phoneList
                };

                //Creating user
                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    //Good to go!
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //Error while creating a user!
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    /*
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    */
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Usuário ou Senha incorretos!");
            }

            return View(model);
        }
    }
}
