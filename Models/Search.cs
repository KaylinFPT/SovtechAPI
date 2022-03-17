using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechAPI.Models
{
    public class Search
    {
        public ChuckSearch chuck { get; set; }

        public SwapiSearch swapi { get; set; }
    }
}
