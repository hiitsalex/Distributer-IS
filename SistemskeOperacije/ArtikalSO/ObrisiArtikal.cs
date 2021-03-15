using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.ArtikalSO
{
    public class ObrisiArtikal : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().obrisi(odo);
        }
    }
}
