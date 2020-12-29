using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.NewPokemon
{
    public class Types : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var types = context.TYPE.ToList();
            return View(types);
        }

    }
}
