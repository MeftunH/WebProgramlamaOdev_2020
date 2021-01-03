using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProje.Models;

namespace WebProje.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly Context _context;
        public string profileImage { get; set; }
        public string user_about { get; set; }
        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IWebHostEnvironment webHostEnvironment,
            Context context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public string Username { get; set; }
        public RegisterModel Register { get; private set; }
        [TempData]
        public string StatusMessage { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }


        public class InputModel
        {
            [Required]
            [Display(Name = "About")]
            public string USER_ABOUT { get; set; }
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [NotMapped]
            [DisplayName("Upload")]
            public IFormFile ProfileImage { get; set; }

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
        private async Task LoadAsync(User user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var userabout = user.USER_ABOUT;
            Username = userName;
            var userbalance = user.USER_BALANCE;
            ViewData["usrblnc"] = user.USER_BALANCE;
            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                USER_ABOUT = userabout
            };
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            var user = await _userManager.GetUserAsync(User);

            ViewData["user"] = user.Imgurl;
            
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
        {


            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }



            string profileImage = user.Imgurl;

            if (Input.ProfileImage != null)
            {
                DeleteFile("images/user", profileImage);
                profileImage = UploadFile(Input.ProfileImage, "images/user");
                Context context = new Context();
                user.Imgurl = profileImage;
                context.USER.Update(user);
                context.SaveChanges();
            }


            var userabout = user.USER_ABOUT;

            if (Input.USER_ABOUT != null)
            {
                user_about = Input.USER_ABOUT;
                Context context = new Context();
                user.USER_ABOUT = user_about;
                context.USER.Update(user);
                context.SaveChanges();
            }
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            // user.Imgurl = file.FileName;
            // await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }

        private string UploadFile(object profileImage, string v)
        {
            throw new NotImplementedException();
        }
    }
}
