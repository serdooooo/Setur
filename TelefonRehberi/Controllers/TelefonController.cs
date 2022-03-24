using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TelefonRehberi.Controllers
{
    public class TelefonController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44310/Rehber/getrehber");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Rehber>>(jsonString);
            return View(values);
        }
    }
    public class Rehber
    {
        public int UUID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public ICollection<Iletisim> Iletisim { get; set; }
    }
    public class Iletisim
    {
        public int IletisimID { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }
        public Rehber Rehberler { get; set; }
    }
}
