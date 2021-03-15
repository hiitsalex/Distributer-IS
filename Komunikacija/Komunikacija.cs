using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;

namespace Komunikacija
{
    public class Komunikacija
    {

        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public object kreirajArtikal()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajArtikal;
            transfer.TransferObjekat = new Artikal();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Korisnik nadjiKorisnika(Korisnik korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiKorisnika;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return (Korisnik)transfer.Rezultat;
        }

        public object zapamtiArtikal(Artikal a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiArtikal;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object pretraziArtikle(Artikal a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziArtikle;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }


        public object pretraziArtikal(Artikal a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziArtikal;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object obrisiArtikal(Artikal a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiArtikal;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
