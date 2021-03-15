using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{

    public enum Operacije { Kraj = 1, KreirajArtikal, ZapamtiArtikal, PretraziArtikle, PretraziArtikal, ObrisiArtikal,
        PronadjiKorisnika
    }
    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;

        public Operacije Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
        Object transferObjekat;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }
        Object rezultat;

        public Object Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
    }
}
