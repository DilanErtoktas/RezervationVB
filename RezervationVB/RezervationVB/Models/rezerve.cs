using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RezervationVB.Models
{
    public class rezerve
    {
        [Key]
        public int rezerveid { get; set; }
        public string sicilno { get; set; }
        public string kullaniciadi { get; set; }
        public DateTime rezervebaslangic { get; set; }
        public DateTime rezervebitis { get; set; }

        [ForeignKey("masa")]
        public int masaid { get; set; }
        public masa masa { get; set; }
    }
}
