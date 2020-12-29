using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class NewPokemonController : Controller
    {
        Context c = new Context();

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult NewPokemon(Models.Pokemon pokemon, int[] typeIDs, int[] weaknessIDs, int[] abilityIDs, List<Models.PokemonStat> pokemonStats)
        {
            List<string> errorMessages = new List<string>();
            int lastID = 0;


            try
            {
                c.POKEMON.Add(pokemon);
                c.SaveChanges();
                lastID = pokemon.POKEMON_ID;

                foreach (int typeID in typeIDs)
                {

                    PokemonType pokemonType = new PokemonType();
                    pokemonType.POKEMON_ID = lastID;
                    pokemonType.TYPE_ID = typeID;

                    try
                    {
                        c.POKEMON_TYPE.Add(pokemonType);
                        c.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        errorMessages.Add(e.Message);

                    }

                }



                foreach (int weaknessID in weaknessIDs)
                {
                    PokemonWeakness pokemonWeakness = new PokemonWeakness();
                    pokemonWeakness.WEAKNESS_ID = weaknessID;
                    pokemonWeakness.POKEMON_ID = lastID;
                    try
                    {
                        c.POKEMON_WEAKNESS.Add(pokemonWeakness);
                        c.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        errorMessages.Add(e.Message);
                    }

                }


                foreach (int abilityID in abilityIDs)
                {
                    PokemonAbility pokemonAbility = new PokemonAbility();
                    pokemonAbility.POKEMON_ID = lastID;
                    pokemonAbility.ABILITY_ID = abilityID;
                    try
                    {
                        c.POKEMON_ABILITY.Add(pokemonAbility);
                        c.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        errorMessages.Add(e.Message);
                    }

                }



                foreach (var pokemonStat in pokemonStats)
                {
                    pokemonStat.POKEMON_ID = lastID;
                    try
                    {
                        c.POKEMON_STAT.Add(pokemonStat);
                        c.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        errorMessages.Add(e.Message);
                    }


                }

                c.SaveChanges();

            }
            catch (Exception e)
            {

                errorMessages.Add(e.Message);
            }

            if (errorMessages.Count == 0)
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessages);
            }

        }
    }
}
