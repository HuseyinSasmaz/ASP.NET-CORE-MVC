using GeziRehberim.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiBookingHotelController : Controller
    {
       
        public async Task <IActionResult> Index()
        {
           
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?order_by=popularity&checkout_date=2024-05-20&filter_by_currency=EUR&locale=tr&units=metric&dest_id=-553173&dest_type=city&adults_number=2&room_number=1&checkin_date=2024-05-19&include_adjacency=true&page_number=0&children_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0"),
                Headers =
    {
        { "X-RapidAPI-Key", "b52f12168fmsh37858560d1b5dfbp1e5d0ejsn91fb323fe6db" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //var bodyReplace = body.Replace(".",",");
                var deger=JsonConvert.DeserializeObject<ApiBookingHotelViewModel.Rootobject>(body);
               
                return View(deger.result);
            }
           
        }
        public async Task<IActionResult> OtelSehirBilgisi()
        {
            return View();
        }
       [HttpPost]
        public async Task<IActionResult> OtelSehirBilgisi(string p)
        {

            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "b52f12168fmsh37858560d1b5dfbp1e5d0ejsn91fb323fe6db" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //var deger = JsonConvert.DeserializeObject<ApiBookingHotelViewModel>(body);
                return View();
            }
           
            
        }
    }
}
