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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonAbility>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.PokemonAbility)
                .HasForeignKey<PokemonAbility>(a => a.POKEMON_ID);

            modelBuilder.Entity<PokemonAbility>()
                .HasOne(a => a.Ability)
                .WithOne(b => b.PokemonAbility)
                .HasForeignKey<PokemonAbility>(a => a.ABILITY_ID);
           
            modelBuilder.Entity<PokemonStat>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.PokemonStat)
                .HasForeignKey<PokemonStat>(a => a.POKEMON_ID);

            modelBuilder.Entity<PokemonStat>()
                .HasOne(a => a.Stat)
                .WithOne(b => b.PokemonStat)
                .HasForeignKey<PokemonStat>(a => a.STAT_ID);
            
            modelBuilder.Entity<PokemonType>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.PokemonType)
                .HasForeignKey<PokemonType>(a => a.POKEMON_ID);

            modelBuilder.Entity<PokemonType>()
                .HasOne(a => a.Type)
                .WithOne(b => b.PokemonType)
                .HasForeignKey<PokemonType>(a => a.TYPE_ID);

            modelBuilder.Entity<PokemonWeakness>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.PokemonWeakness)
                .HasForeignKey<PokemonWeakness>(a => a.POKEMON_ID);

            modelBuilder.Entity<PokemonWeakness>()
                .HasOne(a => a.Weakness)
                .WithOne(b => b.PokemonWeakness)
                .HasForeignKey<PokemonWeakness>(a => a.WEAKNESS_ID);
            
            modelBuilder.Entity<UserPokemon>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.UserPokemon)
                .HasForeignKey<UserPokemon>(a => a.POKEMON_ID);

            modelBuilder.Entity<UserPokemon>()
                .HasOne(a => a.User)
                .WithOne(b => b.UserPokemon)
                .HasForeignKey<UserPokemon>(a => a.USER_ID);
            
            modelBuilder.Entity<UserWishlist>()
                .HasOne(a => a.Pokemon)
                .WithOne(b => b.UserWishlist)
                .HasForeignKey<UserWishlist>(a => a.POKEMON_ID);

            modelBuilder.Entity<UserWishlist>()
                .HasOne(a => a.User)
                .WithOne(b => b.UserWishlist)
                .HasForeignKey<UserWishlist>(a => a.USER_ID);

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
