using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RezervationVB.Models
{
    public class masa
    {
        [Key]
        public int masaid { get; set; }
        public string masaetiketi { get; set; }
        public bool masadurum { get; set; }

        public rezerve rezerve { get; set; }
    }
}
