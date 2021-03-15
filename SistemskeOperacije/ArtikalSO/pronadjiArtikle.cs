using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.ArtikalSO
{
    public class PronadjiArtikle : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Artikal>().ToList<Artikal>();
        }
    }
}
