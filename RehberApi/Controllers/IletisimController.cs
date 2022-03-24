using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RehberApi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IletisimController : ControllerBase
    {
        Context c = new Context();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Iletisim>>> RehberList()
        {
            var returnIletisim =  c.Iletisims
                .Select(x => new
                {
                    ID = x.ID,
                    Telefon = x.Telefon,
                    Mail = x.Mail,
                    Konum = x.Konum,
                    CurrentUUID = x.CurrentUUID,
                }).ToList();
            return Ok(returnIletisim);
        }
        [HttpPost]
        public ActionResult IletisimAdd(Iletisim iletisim)
        {
            c.Add(iletisim);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult IletisimGet(int id)
        {
            var rehber = c.Iletisims.Find(id);
            if (rehber == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rehber);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult IletisimDelete(int id)
        {
            var iletisim = c.Iletisims.Find(id);
            if (iletisim == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(iletisim);
                c.SaveChanges();
                return Ok();
            }
        }
        
    }
}
