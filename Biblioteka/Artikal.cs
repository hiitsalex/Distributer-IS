using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Biblioteka

{
    [Serializable]
   public class Artikal:OpstiDomenskiObjekat
    {
        int id;
        string naziv;
        string proizvodjac;
        DateTime rokTrajanja;
        double cena;
        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public DateTime RokTrajanja { get => rokTrajanja; set => rokTrajanja = value; }
        public double Cena { get => cena; set => cena = value; }
       
        [Browsable(false)]
        public string tabela => "Artikal";
        [Browsable(false)]
        public string kljuc => "ID";
        [Browsable(false)]
        public string uslovJedan => "ID=" + id;
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "Naziv='"+naziv+"', Proizvodjac='"+proizvodjac+"', RokTrajanja='"+rokTrajanja.ToString("yyyy-MM-dd")+"', Cena="+cena;
        [Browsable(false)]
        public string upisivanje => "(ID) values ("+Id+")";



        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Artikal a = new Artikal();
            a.id = Convert.ToInt32(red["ID"]);
            a.Naziv = red["Naziv"].ToString();
            a.Proizvodjac = red["Proizvodjac"].ToString();
            a.rokTrajanja = Convert.ToDateTime(red["RokTrajanja"]);
            a.cena = Convert.ToDouble(red["Cena"]);
            return a;
        }
    }
}
