using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models.ViewModels.Pokemon
{
    public class Stats
    {
        public List<Stat> stats { get; set; }
        public List<PokemonStat> pokemonStats { get; set; }
    }
}
