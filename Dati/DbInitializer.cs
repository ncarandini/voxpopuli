using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voxpopuli.Dati
{
    public static class DbInitializer
    {
        public static void Initialize(VoxPopuliDbContext ctx)
        {
            ctx.Database.EnsureCreated();

            // Cerca se ci sono segnalazioni
            if (ctx.Segnalazioni.Any())
            {
                return;   // Il DB è stato già inizializzato
            }

            var segnalazioni = new Segnalazione[]
            {
                new Segnalazione
                {
                    DataSegnalazione = DateTime.Now,
                    Descrizione = "A via Roma, altezza Bar Lume, c'è una buca gigantesca!",
                    Risolta = false,
                    PresaInCarico = false,
                    Proprietario = String.Empty
                },
                new Segnalazione
                {
                    DataSegnalazione = DateTime.Now,
                    Descrizione = "L'illuminazione stradale di Via dello Scuro, rimane accesa anche di giorno.",
                    Risolta = false,
                    PresaInCarico = false,
                    Proprietario = String.Empty
                }
            };
            foreach(var segnalazione in segnalazioni)
            {
                ctx.Segnalazioni.Add(segnalazione);
            }
            ctx.SaveChanges();
        }

    }
}
