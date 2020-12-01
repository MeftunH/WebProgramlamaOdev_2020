using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Abilities
    {

        [Key]
        public int ABILITY_ID { get; set; }
        public string ABILITY_NAME { get; set; }
        public string ABILITY_DESC { get; set; }
        public ICollection<PokemonAbility> PokemonAbility { get; set; }

    }
}
