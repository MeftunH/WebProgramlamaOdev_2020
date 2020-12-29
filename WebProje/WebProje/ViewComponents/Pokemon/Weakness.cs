using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Pokemon
{
    public class Weakness : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {

            var pokemonWeaknesses = context.POKEMON_WEAKNESS.Where(pw => pw.POKEMON_ID == id).ToList();

            List<Models.Weakness> weaknesses = new List<Models.Weakness>();

            foreach (var pw in pokemonWeaknesses)
            {
                weaknesses.Add(context.WEAKNESS.Find(pw.WEAKNESS_ID));
            }

            return View(weaknesses);
        }
    }
}
