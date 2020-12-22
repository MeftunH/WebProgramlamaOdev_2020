using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers.NewWeaknessController
{
    public class NewWeaknessController : Controller
    {
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]

        [HttpPost]
        public JsonResult NewWeakness(Models.Weakness weakness)
        {
            context.WEAKNESS.Add(weakness);
            context.SaveChanges();
            return Json("başarılı");
        }
    }
}
