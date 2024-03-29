﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AZ_EPortfolio.Models;
using AZ_EPortfolio.Utility;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace AZ_EPortfolio.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(20)]
            [DisplayName("First Name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(20)]
            [DisplayName("Last Name")]
            public string LastName { get; set; }

            [DisplayName("Educational Status")]
            public UserTypes UserType { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //Fetching values of rdUserRole radio type
            string role = Request.Form["rdUserRole"].ToString(); //so, if the admin user has selected Postgraduate, it will be Postgraduate inside the role string

            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser 
                { 
                    UserName = Input.Email, 
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    UserType = Input.UserType
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    //Assigning Roles to New User
                    if(!await _roleManager.RoleExistsAsync(SD.UndergraduateUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.UndergraduateUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.PostgraduateUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.PostgraduateUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.ApprenticeUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.ApprenticeUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.AdminUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.AdminUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.EmployerUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.EmployerUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.DeveloperUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.DeveloperUser));
                    }
                    //check the value of string role
                    if (role == SD.DeveloperUser)
                    {
                        await _userManager.AddToRoleAsync(user, SD.DeveloperUser);
                    }
                    else
                    {
                        if (role == SD.PostgraduateUser)
                        {
                            await _userManager.AddToRoleAsync(user, SD.PostgraduateUser);
                        }
                        else
                        {
                            if (role == SD.ApprenticeUser)
                            {
                                await _userManager.AddToRoleAsync(user, SD.ApprenticeUser);
                            }
                            else
                            {
                                if (role == SD.EmployerUser)
                                {
                                    await _userManager.AddToRoleAsync(user, SD.EmployerUser);
                                }
                                else
                                {
                                    if (role == SD.AdminUser)
                                    {
                                        await _userManager.AddToRoleAsync(user, SD.AdminUser);
                                    }
                                    else
                                    {
                                        if (role == SD.UndergraduateUser)
                                        {
                                            await _userManager.AddToRoleAsync(user, SD.UndergraduateUser);
                                            await _signInManager.SignInAsync(user, isPersistent: false);
                                            return LocalRedirect(returnUrl);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return RedirectToAction("Index", "AzUsers");

                    //_logger.LogInformation("User created a new account with password.");

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    //{
                    //    return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    //}
                    //else
                    //{
                    //
                    //Directly signing in the user
                    //}
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
