using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.Models
{
    public class Type
    {

        [Key]
        public int TYPE_ID { get; set; }
        public string TYPE_NAME { get; set; }
    }
}
