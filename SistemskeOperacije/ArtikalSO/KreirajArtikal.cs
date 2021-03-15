using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.ArtikalSO
{
    public class KreirajArtikal : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Artikal a = odo as Artikal;
            a.Id = Broker.dajSesiju().dajSifru(a);
            Broker.dajSesiju().sacuvaj(a);
            return a;
        }
    }
}
