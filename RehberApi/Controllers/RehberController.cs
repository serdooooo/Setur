using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RehberApi.DataAccessLayer;
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
        Context c = new Context();
        [HttpGet("getrehber")]
        public async Task<ActionResult<IEnumerable<Rehber>>> RehberList()
        {
            var returnRehber = c.Rehbers
                .Select(x => new
                {
                    UUID = x.UUID,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Firma = x.Firma,
                    Iletisim = x.Iletisims.Select(k => new {
                        ID = k.ID,
                        Telefon = k.Telefon,
                        Mail = k.Mail,
                        Konum = k.Konum,
                        CurrentUUID = k.CurrentUUID,

                    })
                }).ToList();
            return Ok(returnRehber);
        }
        [HttpPost]
        public ActionResult RehberAdd(Rehber rehber)
        {
            c.Add(rehber);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult RehberGet(int id)
        {
            var rehber = c.Rehbers.Find(id);
            if (rehber==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rehber);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RehberDelete(int id)
        {
            var rehber = c.Rehbers.Find(id);
            if (rehber==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(rehber);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult RehberUpdate(Rehber rehber)
        {
            var rhbr = c.Find<Rehber>(rehber.UUID);
            if (rhbr==null)
            {
                return NotFound();
            }
            else
            {
                rhbr.Ad = rehber.Ad;
                rhbr.Soyad = rehber.Soyad;
                rhbr.Firma = rehber.Firma;
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
