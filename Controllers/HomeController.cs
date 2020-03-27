using System.Text;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using videos.Models;
using System.Threading.Tasks;

namespace videos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public IActionResult Index()
        {
            throw new IndexOutOfRangeException();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            
            ViewBag.Error = exception.Error.Message;
            ViewBag.StackTrace = exception.Error.StackTrace;
            ViewBag.ExceptionPath = exception.Path;

            var error = new Error();
            error.ErrorMessage = exception.Error.Message;
            error.StackTrace = exception.Error.StackTrace;
            error.ErrorPath = exception.Path;

            await _httpClient.PostAsync("https://localhost:5001/Home/New",CreateHttpContent(error));
            
            return View();
        }

        private HttpContent CreateHttpContent(Error error){
            var json = JsonConvert.SerializeObject(error);
            return new StringContent(json,Encoding.UTF8,"application/json");
        }
    }
}
