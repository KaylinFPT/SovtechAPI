using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SovtechAPI.Models;
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
    public class SearchController : ControllerBase
    {

        HttpClient httpClient;

        public SearchController()
        {
            httpClient = new HttpClient();
        }

        [HttpGet("/search")]
        public async Task<Search> Get(string query)
        {

            var jsonChuck = await httpClient.GetStringAsync($"https://api.chucknorris.io/jokes/search?query={query}");

            var jsonswapi = await httpClient.GetStringAsync($"https://swapi.dev/api/people/?search={query}");

            var swap = JsonConvert.DeserializeObject<SwapiSearch>(jsonswapi);

            var chuck = JsonConvert.DeserializeObject<ChuckSearch>(jsonChuck);

            var search = new Search()
            {
                chuck = chuck,
                swapi = swap
            };

            return search;


        }

       
    }

    

}
