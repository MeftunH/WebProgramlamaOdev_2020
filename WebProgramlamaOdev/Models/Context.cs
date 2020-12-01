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
                .HasOne(pa => pa.Pokemon)
                .WithMany(p => p.PokemonAbility)
                .HasForeignKey(pa => pa.POKEMON_ID);

            modelBuilder.Entity<PokemonAbility>()
                .HasOne(pa => pa.Ability)
                .WithMany(a => a.PokemonAbility)
                .HasForeignKey(pa => pa.ABILITY_ID);
           
            modelBuilder.Entity<PokemonStat>()
                .HasOne(ps => ps.Pokemon)
                .WithMany(p => p.PokemonStat)
                .HasForeignKey(ps => ps.POKEMON_ID);

            modelBuilder.Entity<PokemonStat>()
                .HasOne(ps => ps.Stat)
                .WithMany(p => p.PokemonStat)
                .HasForeignKey(ps => ps.STAT_ID);
            
            modelBuilder.Entity<PokemonType>()
                .HasOne(pt => pt.Pokemon)
                .WithMany(p => p.PokemonType)
                .HasForeignKey(pt => pt.POKEMON_ID);

            modelBuilder.Entity<PokemonType>()
                .HasOne(pt => pt.Type)
                .WithMany(p => p.PokemonType)
                .HasForeignKey(pt => pt.TYPE_ID);

            modelBuilder.Entity<PokemonWeakness>()
                .HasOne(pw => pw.Pokemon)
                .WithMany(p => p.PokemonWeakness)
                .HasForeignKey(pw => pw.POKEMON_ID);

            modelBuilder.Entity<PokemonWeakness>()
                .HasOne(pw => pw.Weakness)
                .WithMany(w => w.PokemonWeakness)
                .HasForeignKey(pw => pw.WEAKNESS_ID);
            
            modelBuilder.Entity<UserPokemon>()
                .HasOne(up => up.Pokemon)
                .WithMany(p => p.UserPokemon)
                .HasForeignKey(up => up.POKEMON_ID);

            modelBuilder.Entity<UserPokemon>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPokemon)
                .HasForeignKey(up => up.USER_ID);
            
            modelBuilder.Entity<UserWishlist>()
                .HasOne(uw => uw.Pokemon)
                .WithMany(p => p.UserWishlist)
                .HasForeignKey(uw => uw.POKEMON_ID);

            modelBuilder.Entity<UserWishlist>()
                .HasOne(uw => uw.User)
                .WithMany(u => u.UserWishlist)
                .HasForeignKey(uw => uw.USER_ID);

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
