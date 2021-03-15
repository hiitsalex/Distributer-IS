using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
   public class Korisnik : OpstiDomenskiObjekat
    {

       private string ime;
       private string prezime;
       private  string sID;
        

        public string tabela => "Korisnik";

        public string kljuc => "SID";

        public string uslovJedan => "SID='"+sID+"'";

        public string uslovVise => null;

        public string azuriranje => null;

        public string upisivanje => null;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string SID { get => sID; set => sID = value; }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Korisnik k = new Korisnik();
           
            k.sID = red["SID"].ToString();
            k.Ime = red["Ime"].ToString();
            k.Prezime = red["Prezime"].ToString();

            
            return k;
        }
    }
}
