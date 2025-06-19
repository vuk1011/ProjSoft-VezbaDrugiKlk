using System.Net.Sockets;
using System.Text.Json;

namespace MreznaKomunikacija
{
    public class Komunikator
    {
        private readonly Socket soket;
        private readonly NetworkStream stream;
        private readonly StreamReader reader;
        private readonly StreamWriter writer;

        public Komunikator(Socket soket)
        {
            this.soket = soket;
            stream = new(soket);
            reader = new(stream);
            writer = new(stream);
            writer.AutoFlush = true;
        }

        public void Zatvori()
        {
            reader.Dispose();
            writer.Dispose();
            stream.Dispose();
        }

        public void Posalji(object obj)
        {
            writer.WriteLine(JsonSerializer.Serialize(obj));
        }

        public T Primi<T>()
        {
            return JsonSerializer.Deserialize<T>(reader.ReadLine());
        }

        public T ProcitajTip<T>(object obj)
        {
            return JsonSerializer.Deserialize<T>((JsonElement)obj);
        }
    }
}
