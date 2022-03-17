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
    public class SwapiController : ControllerBase
    {
        HttpClient httpClient;
        
        public SwapiController()
        {

            httpClient = new HttpClient()
            {
                
                BaseAddress = new Uri("https://swapi.dev/api/")
            
            };

        }


        [HttpGet("/swapi/people")]
        public async Task<SwapiSearch> Get()
        {
            var jsonPeople = await httpClient.GetStringAsync("people/");

            var swap = JsonConvert.DeserializeObject<SwapiSearch>(jsonPeople);

            return swap;
        }

    }
}
