using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Models
{
    public class Suggerimento
    {

        public int Suggerimentoid { get; set; }
        public DateTime data { get; set; }
        public string titolo { get; set; }
        public string descrizione { get; set; }
        public int voti { get; set; }

       

    }
}
