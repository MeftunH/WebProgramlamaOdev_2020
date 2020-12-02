using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.ViewComponents.Pokemon
{
    public class Type:ViewComponent
    {
        Context  context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            var pokemonTypes = context.POKEMON_TYPE.Where(pt => pt.POKEMON_ID == id).ToList();

            List<Models.Type> types = new List<Models.Type>();

            foreach(var pokemonType in pokemonTypes)
            {
                types.Add(context.TYPE.Find(pokemonType.TYPE_ID));
            }

            return View(types);
        }
    }
}
