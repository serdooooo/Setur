using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RehberController : ControllerBase
    {
        private static List<Rehber> RehberList = new List<Rehber>()
        {
            new Rehber(){UUID=1,Ad="Serdar",Soyad="Karakurt",Firma="Setur",iletisim=new Iletisim{ Telefon="055555555",Mail="serdar@gmail.com",Konum="Darica" } },
            new Rehber(){UUID=2,Ad="ali",Soyad="veli",Firma="Setur",iletisim=new Iletisim{ Telefon="05444565465",Mail="ali@gmail.com",Konum="Darica" } },
        };

        [HttpGet("getrehber")]
        public IActionResult Get()
        {
            return Ok(RehberList);
        }
    }
}
