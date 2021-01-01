using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers.Pokemon
{
  
    public class PokemonController : Controller
    {
        Context context = new Context();
        public IActionResult Index(int id)
        {
            var pokemon = context.POKEMON.Find(id);
            return View(pokemon);
        }

        public JsonResult BuyPokemon(int pokemonid)
        {
            Models.Pokemon pokemon = context.POKEMON.Find(pokemonid);
            var user = context.USER.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

          

            try
            {
                var userPokemons = context.USER_POKEMON.Where(up => up.Id == user.Id && up.POKEMON_ID == pokemon.POKEMON_ID).ToList();
                if (userPokemons.Count() != 0)
                {
                    return Json("Bu Pokemona Zaten Sahipsiniz !");
                }
                else
                {
                    if (user.USER_BALANCE >= pokemon.POKEMON_PRICE)
                    {
                        UserPokemon userPokemon = new UserPokemon
                        {
                            Id = user.Id,
                            POKEMON_ID = pokemon.POKEMON_ID,
                            CREATION_DATE = System.DateTime.Now
                        };

                        context.USER_POKEMON.Add(userPokemon);
                        context.SaveChanges(); context.SaveChanges();

                        return Json("success");
                    }
                    else
                    {
                        return Json("Bu Pokemonu Almak İçin Yeterli Bakiyeniz Yok !");
                    }
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);
                
            }
            
        }

        public JsonResult AddToWishList(int pokemonid)
        {
            Models.Pokemon pokemon = context.POKEMON.Find(pokemonid);
            var user = context.USER.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

            try
            {
                var userPokemons = context.USER_POKEMON.Where(up => up.Id == user.Id && up.POKEMON_ID == pokemon.POKEMON_ID).ToList();
                if (userPokemons.Count() != 0)
                {
                    return Json("Bu Pokemona Zaten Sahipsiniz !");
                }
                else
                {
                    var userWishlist = context.USER_WISHLIST.Where(uw => uw.Id == user.Id && uw.POKEMON_ID == pokemon.POKEMON_ID).ToList();
                    
                    if (userWishlist.Count() != 0)
                    {
                        return Json("Bu Pokemon Zaten İstek Listenizde Ekli !");
                    }
                    else
                    {
                        UserWishlist userWish = new UserWishlist
                        {
                            POKEMON_ID = pokemon.POKEMON_ID,
                            Id = user.Id,
                            CREATION_DATE = System.DateTime.Now
                        };

                        context.USER_WISHLIST.Add(userWish);
                        context.SaveChanges();
                        return Json("success");
                    }
                }
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }
    }
}
