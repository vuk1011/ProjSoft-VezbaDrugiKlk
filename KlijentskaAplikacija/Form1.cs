using MreznaKomunikacija;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace KlijentskaAplikacija
{
    public partial class Forma : Form
    {
        private int preostaliPokusaji;
        private int preostaloSlova;
        private List<char> prethodniPokusaji;
        private Socket soket;
        private Komunikator komunikator;

        public Forma()
        {
            preostaliPokusaji = 10;
            preostaloSlova = 5;
            prethodniPokusaji = new List<char>();

            InitializeComponent();
            buttonPokusaj.Click += ButtonPokusaj_Click;
            FormClosing += Forma_FormClosing;
            labelPreostaliPokusaji.Text = preostaliPokusaji.ToString();
            labelPrethodniPokusaji.Text = "";

            #region Podizanje soketa

            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000));
            komunikator = new Komunikator(soket);

            #endregion
        }

        private void Forma_FormClosing(object? sender, FormClosingEventArgs e)
        {
            komunikator?.Zatvori();
            soket?.Close();
        }

        private void ButtonPokusaj_Click(object? sender, EventArgs e)
        {
            var unos = textBoxSlovoPokusaj.Text;
            textBoxSlovoPokusaj.Text = "";
            if (string.IsNullOrEmpty(unos))
            {
                return;
            }
            char slovo = unos[0];
            if (prethodniPokusaji.Contains(slovo))
            {
                return;
            }

            Pokusaj p = new Pokusaj { Slovo = slovo };
            komunikator.Posalji(p);
            Odgovor o = komunikator.Primi<Odgovor>();
            StanjeIgre stanjeIgre = komunikator.ProcitajTip<StanjeIgre>(o.Podaci);

            prethodniPokusaji.Add(slovo);
            labelPrethodniPokusaji.Text = string.Join(",", prethodniPokusaji);
            preostaliPokusaji--;
            labelPreostaliPokusaji.Text = preostaliPokusaji.ToString();

            int brojPogodjenih = stanjeIgre.PozicijaPogodjenih.Count(x => x);
            preostaloSlova -= brojPogodjenih;

            for (int i = 0; i < stanjeIgre.PozicijaPogodjenih.Length; i++)
            {
                if (stanjeIgre.PozicijaPogodjenih[i])
                {
                    switch (i)
                    {
                        case 0:
                            textBoxSlovo1.Text = slovo.ToString();
                            break;
                        case 1:
                            textBoxSlovo2.Text = slovo.ToString();
                            break;
                        case 2:
                            textBoxSlovo3.Text = slovo.ToString();
                            break;
                        case 3:
                            textBoxSlovo4.Text = slovo.ToString();
                            break;
                        case 4:
                            textBoxSlovo5.Text = slovo.ToString();
                            break;
                    }
                }
            }

            if (preostaliPokusaji == 0 || preostaloSlova == 0)
            {
                buttonPokusaj.Enabled = false;
                Task.Run(() =>
                {
                    Odgovor o1 = komunikator.Primi<Odgovor>();
                    string poruka = o1.Poruka;
                    MessageBox.Show(poruka);
                });
            }
        }
    }
}
