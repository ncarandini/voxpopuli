using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Dati
{
    public class Suggerimento
    {
        public int SuggerimentoId { get; set; }
        public DateTime Data { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public int Voti { get; set; }
    }

}
