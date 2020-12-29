using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers.NewAbilityController
{
    public class NewAbilityController : Controller
    {
        Context context = new Context();
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult NewAbility(Models.Abilities ability)
        {
            context.ABILITY.Add(ability);
            context.SaveChanges();
            return Json("başarılı");
        }
    }
}
