﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using WebProje.Models;

namespace WebProje.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public string ProfileImage { get; set; }

        public class InputModel
        {

            [Required]
            [Display(Name = "Kullanici ismi Giriniz")]
            public string UserName { get; set; }
            [Required]
            [Display(Name = "Isim Giriniz")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Soyisim Giriniz")]
            public string Surname { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email giriniz")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Password)]
            [Display(Name = "Sifre giriniz")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Sifreyi onaylayiniz")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            
            [Required]
            [Display(Name = "Dogum Tarihi")]
            [DataType(DataType.Date)]
            public string USER_BIRTHDAY { get; set; }


            [Required]
            [Display(Name = "Profile Image")]
            public IFormFile ProfileImage { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        private string UploadFile(IFormFile img, string path)
        {
            string fileName = null;
            if (img != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, path);
                fileName = DateTime.Now.ToString("yymmssff") + "-" + img.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        private void DeleteFile(string path, string file)
        {
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, path);
            string fileURL = Path.Combine(uploadDir, file);

            if (System.IO.File.Exists(fileURL))
            {
                System.IO.File.Delete(fileURL);
            }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            string profileImage = UploadFile(Input.ProfileImage, "images/user");

            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                string toBeParsedStr = Input.USER_BIRTHDAY;
                toBeParsedStr = toBeParsedStr.Substring(0, 10);
                Input.USER_BIRTHDAY = toBeParsedStr;
                var user = new User { UserName = Input.Email, Email = Input.Email, Name = Input.Name, Surname = Input.Surname, USER_BIRTHDATE = Convert.ToDateTime(DateTime.ParseExact(Input.USER_BIRTHDAY, "MM/dd/yyyy", CultureInfo.InvariantCulture)), Imgurl = profileImage, USER_BALANCE = 10000 };


                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private string DeleteFile(IFormFile profileImage, string v)
        {
            throw new NotImplementedException();
        }
    }
}
