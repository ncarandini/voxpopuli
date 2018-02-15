using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Models
{
    public class Suggerimento
    {
        int SuggerimentoId { get; set; }
        DateTime data { get; set; }
        string titolo { get; set; }
        string descrizione { get; set; }
        int voti { get; set; }

    }
}
