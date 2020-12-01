using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.ViewComponents.Admin
{
    public class Weakness:ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var weaknesses = context.WEAKNESS.ToList();

            return View(weaknesses);
        }
    }
}
