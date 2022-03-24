using RehberApi.DataAccessLayer;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi
{

    public class Rehber
    {
        [Key]
        public int UUID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public ICollection<Iletisim> Iletisim { get; set; }
    }
}
