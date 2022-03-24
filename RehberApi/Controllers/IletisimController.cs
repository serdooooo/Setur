using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult IletisimList()
        {
            var values = c.Iletisims.ToList();
            return Ok(values);
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
        [HttpPut]
        public IActionResult IletisimUpdate(Iletisim iletisim)
        {
            var ilt = c.Find<Iletisim>(iletisim.IletisimID);
            if (ilt == null)
            {
                return NotFound();
            }
            else
            {

                ilt.Mail = iletisim.Mail;
                ilt.Telefon = iletisim.Telefon;
                ilt.Konum = iletisim.Konum;
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
