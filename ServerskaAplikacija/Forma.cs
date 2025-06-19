using System.Net;
using System.Net.Sockets;

namespace ServerskaAplikacija
{
    public partial class Forma : Form
    {
        internal Igra igra;
        private Socket soket;
        private ClientHandler[] igraci;

        public Forma()
        {
            igra = new Igra();
            igraci = new ClientHandler[2];

            InitializeComponent();
            FormClosing += Forma_FormClosing;
            Load += Forma_Load;

            labelZadataRec.Text = igra.Rec.ToUpper();
        }

        private void Forma_Load(object? sender, EventArgs e)
        {
            Task.Run(() =>
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000));

                soket.Listen();
                for (int i = 0; i < igraci.Length; i++)
                {
                    Socket klijentovSoket = soket.Accept();
                    igraci[i] = new ClientHandler(klijentovSoket, i, this);
                }

                List<Task> igranjeIgre = new List<Task>();
                foreach (var igrac in igraci)
                {
                    igranjeIgre.Add(Task.Run(() => igrac.Handle()));
                }
                Task.WhenAll(igranjeIgre).Wait();

                foreach (var igrac in igraci)
                {
                    if (igrac.pogodio)
                    {
                        igrac.ObavestiOIshoduIgre("Pobedili ste.");
                    }
                    else
                    {
                        igrac.ObavestiOIshoduIgre("Izgubili ste.");
                    }
                }

                foreach (var igrac in igraci)
                {
                    igrac.Zatvori();
                }
             });
        }

        private void Forma_FormClosing(object? sender, FormClosingEventArgs e)
        {
            soket?.Close();
        }

        public void PostaviRezultatIgraca(int brojIgraca, int brojPokusaja, int brojPogodjenih)
        {
            switch (brojIgraca)
            {
                case 0:
                    labelBrPokusaja1.Text = brojPokusaja.ToString();
                    labelBrPogodjenih1.Text = brojPogodjenih.ToString();
                    break;
                case 1:
                    labelBrPokusaja2.Text = brojPokusaja.ToString();
                    labelBrPogodjenih2.Text = brojPogodjenih.ToString();
                    break;
            }
        }
    }
}
