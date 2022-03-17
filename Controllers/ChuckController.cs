using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SovtechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        HttpClient httpClient;
        public ChuckController()
        {
            httpClient = new HttpClient() 
            { 
                BaseAddress = new Uri("https://api.chucknorris.io/")
            };
        }


        [HttpGet("/chuck/categories")]
        public async Task<string> Get()
        {
            var jsonCategories = await httpClient.GetStringAsync("jokes/categories");

            return jsonCategories;
        }

       
    }
}
