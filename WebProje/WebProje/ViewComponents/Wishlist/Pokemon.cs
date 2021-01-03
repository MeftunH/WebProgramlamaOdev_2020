using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Wishlist
{
    public class Pokemons : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(string userid)
        {
            var userWishlist = context.USER_WISHLIST.Where(uw => uw.Id == userid).ToList();
            List<Models.Pokemon> pokemons = new List<Models.Pokemon>();

            foreach (var wish in userWishlist)
            {
                pokemons.Add(context.POKEMON.Where(p => p.POKEMON_ID == wish.POKEMON_ID).FirstOrDefault());
            }

            return View(pokemons);
        }
    }
}
