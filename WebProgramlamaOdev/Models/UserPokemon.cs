using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class UserPokemon
    {

        [Key]
        public int USER_POKEMON_ID { get; set; }
        public int USER_ID { get; set; }
        public int POKEMON_ID { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }

    }
}
