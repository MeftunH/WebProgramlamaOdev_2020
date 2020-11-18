using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class PokemonWeakness
    {

        [Key]
        public int POKEMON_WEAKNESS_ID { get; set; }

        public ICollection<Pokemon> POKEMON_ID { get; set; }
        public ICollection<Weakness> WEAKNESS_ID { get; set; }
    }
}
