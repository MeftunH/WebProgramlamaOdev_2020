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
        public string POKEMON_NAME { get; set; }
        public string POKEMON_HEIGHT { get; set; }
        public string POKEMON_WEIGHT { get; set; }
        public string POKEMON_CATEGORY { get; set; }
        public string POKEMON_IMG_URL { get; set; }
        public int POKEMON_PRICE { get; set; }
        public ICollection<PokemonAbility> PokemonAbility { get; set; }
        public ICollection<PokemonStat> PokemonStat { get; set; }
        public ICollection<PokemonType> PokemonType { get; set; }
        public ICollection<PokemonWeakness> PokemonWeakness { get; set; }
        public ICollection<UserPokemon> UserPokemon { get; set; }
        public ICollection<UserWishlist> UserWishlist { get; set; }
    }
}
