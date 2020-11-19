using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class PokemonType
    {
        [Key]
        public int POKEMON_TYPE_ID { get; set; }
        public int POKEMON_ID { get; set; }
        public int TYPE_ID { get; set; }
        public Pokemon Pokemon { get; set; }
        public Type Type { get; set; }
    }
}
