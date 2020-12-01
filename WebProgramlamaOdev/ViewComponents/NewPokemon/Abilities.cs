using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.ViewComponents.NewPokemon
{
    public class Abilities : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var abilities = context.ABILITY.ToList();

            return View(abilities);
        }
    }
}
