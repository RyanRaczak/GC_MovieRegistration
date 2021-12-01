using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_MovieRegistration.Models
{
    public class Movie
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
    }
}
