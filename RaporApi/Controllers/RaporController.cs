using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaporApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RaporController : ControllerBase
    {

        private static List<Rapor> raporList = new List<Rapor>()
        {
            new Rapor(){UUID=1,raporDurum="Tamamlandı",raporDate=DateTime.Now },
            new Rapor(){UUID=2,raporDurum="Hazirlaniyor",raporDate=DateTime.Now },
        };

        [HttpGet("getrapor")]
        public IActionResult Get()
        {
            return Ok(raporList);
        }
    }
}
