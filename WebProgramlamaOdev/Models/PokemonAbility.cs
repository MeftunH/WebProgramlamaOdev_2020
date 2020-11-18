using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class PokemonAbility
    {

        [Key]
        public int POKEMON_ABILITY_ID { get; set; }
        public ICollection<Pokemon> POKEMON_ID { get; set; }
        public ICollection<Abilities> ABILITY_ID { get; set; }
    }
}
