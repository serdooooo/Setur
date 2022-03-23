using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }
    }
    public class Rehber
    {
        [Key]
        public int UUID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public Iletisim iletisim { get; set; }

    }
}
