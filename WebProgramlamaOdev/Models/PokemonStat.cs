using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class PokemonStat
    {
        [Key]
        public int POKEMON_STAT_ID { get; set; }
        public ICollection<Pokemon> POKEMON_ID { get; set; }
        public ICollection<Stat> STAT_ID { get; set; }
        public int STAT_VALUE { get; set; }
    }
}
