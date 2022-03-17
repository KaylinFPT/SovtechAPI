using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechAPI.Models
{
    public class SwapiSearch
    {
        public int count { get; set; }

        public string next { get; set; }

        public string previous { get; set; }

        public List<SwPeople> results { get; set; }
    }
}
