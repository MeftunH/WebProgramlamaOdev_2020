using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers.Pokemon
{
    public class PokemonController : Controller
    {
        Context context = new Context();
        public IActionResult Index(int id)
        {
            var pokemon = context.POKEMON.Find(id);
            return View(pokemon);
        }
    }
}
