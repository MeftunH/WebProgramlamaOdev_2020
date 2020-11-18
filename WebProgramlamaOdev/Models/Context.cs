using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //Connection String Buraya Yazılacak.
            optionsBuilder.UseSqlServer("server=DESKTOP-N1H4DB1; database=corepokedex;integrated security=true;");
        }
        public DbSet<Pokemon> POKEMON { get; set; }
        public DbSet<Type> TYPE { get; set; }
        public DbSet<PokemonType> POKEMON_TYPE { get; set; }
        public DbSet<Stat> STAT { get; set; }
        public DbSet<PokemonStat> POKEMON_STAT { get; set; }
        public DbSet<Abilities> ABILITY { get; set; }
        public DbSet<PokemonAbility> POKEMON_ABILITY { get; set; }
        public DbSet<Weakness> WEAKNESS { get; set; }
        public DbSet<PokemonWeakness> POKEMON_WEAKNESS { get; set; }
        public DbSet<User> USER { get; set; }
        public DbSet<UserPokemon> USER_POKEMON { get; set; }
        public DbSet<UserWishlist> USER_WISHLIST { get; set; }

        




        
    }
}
