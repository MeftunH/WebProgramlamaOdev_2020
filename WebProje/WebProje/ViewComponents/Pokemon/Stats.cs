using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.ViewComponents.Pokemon
{
    public class Stats : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            Models.ViewModels.Pokemon.Stats model = new Models.ViewModels.Pokemon.Stats();

            var pokemonStats = context.POKEMON_STAT.Where(ps => ps.POKEMON_ID == id).ToList();

            List<Stat> stats = new List<Stat>();
            foreach (var ps in pokemonStats)
            {
                stats.Add(context.STAT.Find(ps.STAT_ID));
            }

            model.pokemonStats = pokemonStats;
            model.stats = stats;
            return View(model);
        }
    }
}
