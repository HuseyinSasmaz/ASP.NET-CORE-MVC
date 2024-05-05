using GeziRehberim.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    //[Route("Admin/[controller]/[action]")]
    public class ZiyaretcilerApiController : Controller
    {
        private readonly HttpClient httpClient;

        public ZiyaretcilerApiController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            string apiUrl = "http://localhost:5268/api/Ziyaretciler";
              var  response=await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseData =await response.Content.ReadAsStringAsync();
                var result=JsonConvert.DeserializeObject<List<ZiyaretcilerViewModel>>(responseData); 
                return Ok(result);
            }
            else
            {
                return View();
            }
             
           
        }
    }
}
