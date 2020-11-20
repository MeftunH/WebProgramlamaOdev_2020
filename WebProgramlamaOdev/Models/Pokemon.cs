using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Pokemon
    {
        [Key]
        public int POKEMON_ID { get; set; }
        public string POKEMON_HEIGHT { get; set; }
        public string POKEMON_WEIGHT { get; set; }
        public string POKEMON_CATEGORY { get; set; }
        public string POKEMON_IMG_URL { get; set; }
        public int POKEMON_PRICE { get; set; }
        public PokemonAbility PokemonAbility { get; set; }
        public PokemonStat PokemonStat { get; set; }
        public PokemonType PokemonType { get; set; }
        public PokemonWeakness PokemonWeakness { get; set; }
        public UserPokemon UserPokemon { get; set; }
        public UserWishlist UserWishlist { get; set; }
    }
}
