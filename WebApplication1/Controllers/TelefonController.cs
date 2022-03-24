using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class TelefonController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44306/Rehber/getrehber");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Rehber>>(jsonString);
            return View(values);
        }
        public IActionResult AddRehber()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRehber(Rehber r)
        {
            var httpClient = new HttpClient();
            var jsonRehber = JsonConvert.SerializeObject(r);
            StringContent content = new StringContent(jsonRehber, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44310/Rehber", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(r);
        }
        [HttpGet]
        public async Task<IActionResult> EditRehber(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44310/Rehber/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonRehber = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Rehber>(jsonRehber);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditRehber(Rehber r)
        {
            var httpClient = new HttpClient();
            var jsonRehber = JsonConvert.SerializeObject(r);
            var content = new StringContent(jsonRehber, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44310/Rehber",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(r);
        }
        public async Task<IActionResult> DeleteRehber(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44310/Rehber/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> IletisimIndex()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44310/api/Iletisim");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Iletisim>>(jsonString);
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetIdIletisimIndex(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44310/Iletisim/" + id);
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Iletisim>>(jsonString);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(values);
        }

        public async Task<IActionResult> DeleteIletisim(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44310/api/Iletisim/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        //https://localhost:44306/Rapor/getrapor
        public async Task<IActionResult> RaporIndex()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44306/Rapor/getrapor");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Rapor>>(jsonString);
            return View(values);
        }




        public IActionResult AddRapor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRapor(Rapor r)
        {
            var httpClient = new HttpClient();
            var jsonRapor = JsonConvert.SerializeObject(r);
            StringContent content = new StringContent(jsonRapor, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44366/Rapor", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(r);
        }
        [HttpGet]
        public async Task<IActionResult> EditRapor(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44366/Rapor/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonRapor = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Rapor>(jsonRapor);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditRapor(Rapor r)
        {
            var httpClient = new HttpClient();
            var jsonRapor = JsonConvert.SerializeObject(r);
            var content = new StringContent(jsonRapor, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44366/Rapor", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(r);
        }
        public async Task<IActionResult> DeleteRapor(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44366/Rapor/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


    }
    public class Rehber
        {
            public int UUID { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Firma { get; set; }
            public ICollection<Iletisim> Iletisims { get; set; }
        }
        public class Iletisim
        {
            public int ID { get; set; }
            public string Telefon { get; set; }
            public string Mail { get; set; }
            public string Konum { get; set; }

            public int CurrentUUID { get; set; }
            public Rehber Rehber { get; set; }
        }
    public class Rapor
    {
        public int UUID { get; set; }
        public DateTime raporDate { get; set; } = DateTime.Now;
        public string raporDurum { get; set; }
    }
}
