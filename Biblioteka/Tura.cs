using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
namespace Biblioteka
{
    [Serializable]
    public class Tura:OpstiDomenskiObjekat
    {
        int id;
        DateTime datum;
        Skladiste skladiste;
        Vozac vozac;
        List<StavkaTure> stavkeTure;

        
        public int Id { get => id; set => id = value; }
        
        public DateTime Datum { get => datum; set => datum = value; }
        

        internal Skladiste Skladiste { get => skladiste; set => skladiste = value; }
        

        internal Vozac Vozac { get => vozac; set => vozac = value; }
        [Browsable(false)]

        public string tabela => "Tura";
        [Browsable(false)]

        public string kljuc => "ID";
        [Browsable(false)]

        public string uslovJedan => "ID=" + id;
        [Browsable(false)]

        public string USLOV;
        [Browsable(false)]

        public string uslovVise => USLOV;
        [Browsable(false)]


        public string azuriranje => null;
        [Browsable(false)]


        public string upisivanje => null;
        [Browsable(false)]


        public List<StavkaTure> StavkeTure { get => stavkeTure; set => stavkeTure = value; }

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Tura t = new Tura();
            t.id = Convert.ToInt32(red["ID"]);
            t.datum = Convert.ToDateTime(red["Datum"]);
            t.skladiste.Id = Convert.ToInt32(red["SkladisteId"]);
            t.vozac.Id = Convert.ToInt32(red["VozacId"]);
            return t;
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            throw new NotImplementedException();
        }
    }
}
