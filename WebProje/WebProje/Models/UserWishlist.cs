﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    //private class WishList
    //{
    //private List<UserWishlist> pokemons=new List<UserWishlist>();
    //    public List<UserWishlist> Pokemons => pokemons;
    //}

    public class UserWishlist
    {
        [Key]
        public int USER_WISH_ID { get; set; }
        public int POKEMON_ID { get; set; }
        public string Id { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public User User { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
