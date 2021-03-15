using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
namespace Biblioteka
{
    [Serializable]
    public class StavkaTure:OpstiDomenskiObjekat
    {
        int rBr;
        int kolicina;
        int turaID;
        Artikal artikal;
        Kupac kupac;

        public int RBr { get => rBr; set => rBr = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public Artikal Artikal { get => artikal; set => artikal = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        [Browsable(false)]
        public string tabela => "StavkaTure";
        [Browsable(false)]
        public string kljuc => "RBr";
        [Browsable(false)]
        public string uslovJedan => "Rbr=" + rBr+"and TuraId="+turaID;
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => null;
        [Browsable(false)]
        public string upisivanje => null;
        [Browsable(false)]
        public int TuraID { get => turaID; set => turaID = value; }

        [Browsable(false)]
        

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            StavkaTure st = new StavkaTure();
            st.rBr = Convert.ToInt32(red["RBr"]);
            st.turaID = Convert.ToInt32(red["TuraId"]);
            st.kolicina = Convert.ToInt32(red["Kolicina"]);
            st.artikal.Id = Convert.ToInt32(red["ArtikalId"]);
            st.kupac.Id = Convert.ToInt32(red["KupacId"]);
            return st;
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            throw new NotImplementedException();
        }
    }
}
