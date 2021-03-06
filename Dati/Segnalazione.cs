﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Dati
{
    public class Segnalazione
    {
        public int SegnalazioneId { get; set; }

        public string Descrizione { get; set; }

        public string Proprietario { get; set;}

        public DateTime DataSegnalazione { get; set; }

        public bool PresaInCarico { get; set; }

        public bool Risolta { get; set; }
    }
}
