using GeziRehberim.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]    
    public class ApiMovieController : Controller
    {
        public async  Task<IActionResult> Index()
        {
          // List<ApiFilmViewModel> apiFilmViewModels = new List<ApiFilmViewModel>();
          
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "b52f12168fmsh37858560d1b5dfbp1e5d0ejsn91fb323fe6db" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               // ApiFilmViewModel apiFilmViewModel = JsonConvert.DeserializeObject<ApiFilmViewModel>(body);
                 List<ApiFilmViewModel> apiFilmViewModels = JsonConvert.DeserializeObject<List<ApiFilmViewModel>>(body);

                return View(apiFilmViewModels);
            }
           
            
          
        }
    }
}
