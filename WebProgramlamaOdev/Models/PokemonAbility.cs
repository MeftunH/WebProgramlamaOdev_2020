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
        public int POKEMON_ID { get; set; }
        public Pokemon Pokemon { get; set; }
        public Abilities Ability { get; set; }
        public int ABILITY_ID { get; set; }
    }
}
