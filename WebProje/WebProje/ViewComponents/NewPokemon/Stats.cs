﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.NewPokemon
{
    public class Stats : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var stats = context.STAT.ToList();
            return View(stats);
        }
    }
}
