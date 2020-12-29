using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers.NewStatController
{
    
        public class NewStatController : Controller
    {
        Context context = new Context();

        [Authorize(Roles = "Admin")]
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
