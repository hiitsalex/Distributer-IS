using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
namespace Biblioteka
{
    [Serializable]
    public class Vozac:OpstiDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        [Browsable(false)]

        public string tabela => "Vozac";
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

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Vozac v = new Vozac();
            v.id = Convert.ToInt32(red["ID"]);
            v.Ime = red["Ime"].ToString();
            v.Prezime = red["Prezime"].ToString();
           

            return v;
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            throw new NotImplementedException();
        }
    }
}
