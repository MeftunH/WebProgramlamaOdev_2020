using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Weakness
    {

        [Key]
        public int WEAKNESS_ID { get; set; }
        public string WEAKNESS_NAME { get; set; }
    }
}
