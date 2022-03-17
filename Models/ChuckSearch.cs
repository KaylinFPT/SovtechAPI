using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechAPI.Models
{
    public class ChuckSearch
    {
        public int total { get; set; }

        public List<ChuckJoke> result { get; set; }
    }
}
