using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaporApi
{
    public class Rapor
    {
        [Key]
        public int UUID { get; set; }
        public DateTime raporDate { get; set; }
        public string raporDurum { get; set; }
    }
}
