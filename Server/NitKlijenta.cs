using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteka;
using Sesija;
using SistemskeOperacije;
using SistemskeOperacije.ArtikalSO;

namespace Server
{
    public class NitKlijenta
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiKorisnika:
                            PrijavaKorisnika pk = new PrijavaKorisnika();
                            transfer.Rezultat = pk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajArtikal:
                            KreirajArtikal ka = new KreirajArtikal();
                            transfer.Rezultat = ka.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                       
                        case Operacije.ZapamtiArtikal:
                            ZapamtiArtikal za = new ZapamtiArtikal();
                            transfer.Rezultat = za.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                      
                        case Operacije.PretraziArtikle:
                            PronadjiArtikle pa1 = new PronadjiArtikle();
                            transfer.Rezultat = pa1.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                       
                        case Operacije.PretraziArtikal:
                            PronadjiArtikal pa2 = new PronadjiArtikal();
                            transfer.Rezultat = pa2.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                       
                        case Operacije.ObrisiArtikal:
                            ObrisiArtikal oa = new ObrisiArtikal();
                            transfer.Rezultat = oa.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        
                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaKorisnika.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

                Server.listaKorisnika.Remove(tok);
                
            }
        }
    }
}
