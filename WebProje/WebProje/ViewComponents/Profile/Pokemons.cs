using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Profile
{
    public class Pokemons:ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(string userid)
        {
            var userPokemons = context.USER_POKEMON.Where(up => up.Id == userid).ToList();

            List<Models.Pokemon> pokemons = new List<Models.Pokemon>();

            foreach (var up in userPokemons)
            {
                pokemons.Add(context.POKEMON.Where(p => p.POKEMON_ID == up.POKEMON_ID).FirstOrDefault());
            }

            return View(pokemons);

        }
    }
}
