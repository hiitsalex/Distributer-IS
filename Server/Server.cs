using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteka;

namespace Server
{
    public class Server
    {
        public static List<NetworkStream> listaKorisnika = new List<NetworkStream>();
        Socket soket;
        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint ep = new IPEndPoint(IPAddress.Any, 10000);
                soket.Bind(ep);


                ThreadStart ts = osluskuj;
                Thread nit = new Thread(ts);
                nit.Start();


                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public void osluskuj()
        {
            try
            {
                soket.Listen(6);
                while (true)
                {
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    listaKorisnika.Add(tok);
                    new NitKlijenta(tok);
                }
            }
            catch (Exception)
            {

                
            }
        }

        public bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
