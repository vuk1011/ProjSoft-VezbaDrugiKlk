namespace ServerskaAplikacija
{
    internal class Igra
    {
        private static readonly string[] moguceReci = { "trava", "vrata", "mesto", "rerna", "ptica" };
        public string Rec { get; private set; }

        public Igra()
        {
            var nasumicanBroj = new Random().Next(moguceReci.Length);
            Rec = moguceReci[nasumicanBroj].ToUpper();
        }

        public bool[] VratiPozicijePodogjenih(char slovo)
        {
            var rezultat = new bool[moguceReci[0].Length];
            for (int i = 0; i < Rec.Length; i++)
            {
                if (slovo == Rec[i])
                {
                    rezultat[i] = true;
                }
            }
            return rezultat;
        }
    }
}
