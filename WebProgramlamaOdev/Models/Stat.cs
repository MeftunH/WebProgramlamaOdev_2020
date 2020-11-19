using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Stat
    {

        [Key]
        public int STAT_ID { get; set; }
        public string STAT_NAME { get; set; }
        public PokemonStat PokemonStat { get; set; }


    }
}
