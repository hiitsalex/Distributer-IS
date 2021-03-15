using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije
{
    public class PrijavaKorisnika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Korisnik k = odo as Korisnik;
            return Broker.dajSesiju().dajZaUslovJedan(odo);
        }
    }
}
