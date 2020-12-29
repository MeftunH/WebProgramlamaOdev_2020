using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class PokemonWeakness
    {

        [Key]
        public int POKEMON_WEAKNESS_ID { get; set; }

        public int POKEMON_ID { get; set; }
        public int WEAKNESS_ID { get; set; }
        public Pokemon Pokemon { get; set; }
        public Weakness Weakness { get; set; }
    }
}
