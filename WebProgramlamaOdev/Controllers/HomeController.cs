using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();

        public IActionResult Index(string searchString)
        {
            if (searchString == null)
            {
                var pokemons = context.POKEMON.ToList();

                return View(pokemons);
            }
            else
            {
                var pokemons = context.POKEMON.Where(p => p.POKEMON_NAME.Contains(searchString)).ToList();
                return View(pokemons);
            }
          
        }
      
    }
}
