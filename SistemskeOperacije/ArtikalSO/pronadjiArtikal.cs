using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.ArtikalSO
{
    public class PronadjiArtikal : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Artikal a = odo as Artikal;
            a = Broker.dajSesiju().dajZaUslovJedan(a) as Artikal;
            return a;
        }
    }
}
