using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;


namespace WebProje.Controllers.NewWeaknessController
{
    public class NewWeaknessController : Controller
    {
        Context context = new Context();
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public JsonResult NewWeakness(Models.Weakness weakness)
        {
            context.WEAKNESS.Add(weakness);
            context.SaveChanges();
            return Json("başarılı");
        }
    }
}
