using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class NewTypeController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult NewType(Models.Type type)
        {
            context.TYPE.Add(type);
            context.SaveChanges();

            return Json("başarılı");
        }
    }
}
