﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Admin
{
    public class Type : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var types = context.TYPE.ToList();
            return View(types);
        }
    }
}
