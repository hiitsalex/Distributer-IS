using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
namespace Biblioteka
{
    [Serializable]
    public class Kupac:OpstiDomenskiObjekat
    {
        int id;
        string Ime;
        string Prezime;
        string telefon;
        string adresa;

        public int Id { get => id; set => id = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        [Browsable(false)]
        public string tabela => "Kupac";
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
            Kupac k = new Kupac();
            k.id = Convert.ToInt32(red["ID"]);
            k.Ime = red["Ime"].ToString();
           k.Prezime = red["Prezime"].ToString();
            k.Telefon = red["Telefon"].ToString();
            k.Adresa = red["Adresa"].ToString();

            return k;
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            throw new NotImplementedException();
        }
    }
}
