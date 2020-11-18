using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class User
    {

        [Key]
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_MAIL { get; set; }
        public string USER_PASSWORD { get; set; }
        public string USER_ABOUT { get; set; }
        [DataType(DataType.Date)]
        public DateTime USER_BIRTHDATE { get; set; }
        public int USER_BALANCE { get; set; }
        public bool USER_ISADMIN { get; set; }
    }
}
