using MreznaKomunikacija;
using System.Linq;
using System.Net.Sockets;

namespace ServerskaAplikacija
{
    internal class ClientHandler
    {
        private Socket soket;
        private Komunikator komunikator;
        internal int preostaloPokusaja;
        private int brojIgraca;
        private Forma forma;
        private int preostaloSlova;
        internal bool pogodio;

        public ClientHandler(Socket s, int brojIgraca, Forma f)
        {
            soket = s;
            komunikator = new Komunikator(s);
            preostaloPokusaja = 10;
            this.brojIgraca = brojIgraca;
            forma = f;
            preostaloSlova = 5;
        }

        public void Handle()
        {
            while (preostaloPokusaja > 0 && !pogodio)
            {
                Pokusaj p = komunikator.Primi<Pokusaj>();
                Odgovor o = new Odgovor { Signal = true };

                char slovo = p.Slovo;
                var pozicijePogodjenih = forma.igra.VratiPozicijePodogjenih(slovo);
                int brojPogodjenih = pozicijePogodjenih.Count(x => x);

                preostaloSlova -= brojPogodjenih;
                if (preostaloSlova == 0)
                {
                    pogodio = true;
                }

                o.Podaci = new StanjeIgre { PozicijaPogodjenih = pozicijePogodjenih };
                komunikator.Posalji(o);

                preostaloPokusaja--;
                forma.Invoke(() => forma.PostaviRezultatIgraca(brojIgraca, 10 - preostaloPokusaja, 5 - preostaloSlova));
            }
        }

        public void ObavestiOIshoduIgre(string poruka)
        {
            Odgovor o = new Odgovor { Signal = true , Poruka = poruka};
            komunikator.Posalji(o);
        }

        public void Zatvori()
        {
            komunikator?.Zatvori();
            soket?.Close();
        }
    }
}
