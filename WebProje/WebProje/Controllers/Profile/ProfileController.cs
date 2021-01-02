using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers.Profile
{
    public class ProfileController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {

            Models.User user = context.USER.Where(u => u.Email == User.Identity.Name).FirstOrDefault();
            return View(user);
        }
    }
}
