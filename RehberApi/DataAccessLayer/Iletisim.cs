using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RehberApi.DataAccessLayer;

namespace RehberApi.DataAccessLayer
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }

        public int? CurrentUUID { get; set; }
        public Rehber Rehber { get; set; }
    }
}
