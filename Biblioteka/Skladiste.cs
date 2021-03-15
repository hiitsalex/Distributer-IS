using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Skladiste:OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        string adresa;
        double kvadratura;

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public double Kvadratura { get => kvadratura; set => kvadratura = value; }
        [Browsable(false)]
        public string tabela => "Skladiste";
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
            Skladiste s = new Skladiste();
            s.id = Convert.ToInt32(red["ID"]);
            s.Naziv = red["Naziv"].ToString();
            s.kvadratura = Convert.ToDouble(red["Kvadratura"]);
            s.Adresa = red["Adresa"].ToString();

            return s;
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            throw new NotImplementedException();
        }
    }
}
