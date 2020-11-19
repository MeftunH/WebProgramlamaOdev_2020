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
        public int POKEMON_ID { get; set; }
        public int STAT_ID { get; set; }
        public int STAT_VALUE { get; set; }
        public Pokemon Pokemon { get; set; }
        public Stat Stat { get; set; }
    }
}
