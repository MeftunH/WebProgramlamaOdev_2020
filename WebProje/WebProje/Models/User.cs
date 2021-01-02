using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Surname { get; set; }
        [PersonalData]
        [Column(TypeName="nvarchar(400)")]
        public string USER_ABOUT { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime USER_BIRTHDATE { get; set; }

        public string Imgurl { get; set; }
        public int USER_BALANCE { get; set; }
        public ICollection<UserPokemon> UserPokemon { get; set; }
        public ICollection<UserWishlist> UserWishlist { get; set; }

        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
