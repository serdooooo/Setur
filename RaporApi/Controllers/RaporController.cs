using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaporApi.DataAccessLayer;
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
        Context c = new Context();

        [HttpGet("getrapor")]
        public IActionResult Get()
        {
            var values = c.Rapors.ToList();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult RaporAdd(Rapor rapor)
        {
            c.Add(rapor);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult RaporGet(int id)
        {
            var rapor = c.Rapors.Find(id);
            if (rapor == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rapor);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RaporDelete(int id)
        {
            var rapor = c.Rapors.Find(id);
            if (rapor == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(rapor);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult RehberUpdate(Rapor rapor)
        {
            var r = c.Find<Rapor>(rapor.UUID);
            if (r == null)
            {
                return NotFound();
            }
            else
            {
                r.raporDate = rapor.raporDate;
                r.raporDurum = rapor.raporDurum;
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
