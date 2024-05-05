using GeziRehberim.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace GeziRehberim.Areas.Admin.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
           List<BookingExchangeViewModel2> bookingExchanges = new List<BookingExchangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
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
                var sonuc=JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(sonuc.exchange_rates);
            }

        }
    }
}
