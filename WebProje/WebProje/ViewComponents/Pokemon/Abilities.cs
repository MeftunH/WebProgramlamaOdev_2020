using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Pokemon
{
    public class Ability : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            var pokemonAbilities = context.POKEMON_ABILITY.Where(pa => pa.POKEMON_ID == id).ToList();

            List<Models.Abilities> abilities = new List<Abilities>();



            foreach (var pokemonAbility in pokemonAbilities)
            {
                try
                {

                    abilities.Add(context.ABILITY.Find(pokemonAbility.ABILITY_ID));

                }
                catch (Exception e)
                {


                }


            }

            return View(abilities);
        }
    }
}
