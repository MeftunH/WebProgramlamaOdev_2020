using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers.NewStatController
{
    public class NewStatController : Controller
    {
        Context context = new Context();

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public JsonResult NewStat(Models.Stat stat)
        {
            
            context.STAT.Add(stat);
            context.SaveChanges();
            return Json("başarılı");
        }
    }
}
