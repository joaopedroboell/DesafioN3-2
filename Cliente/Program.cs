using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Cliente...");
            GetResultApiAsync(10).GetAwaiter().GetResult();
        }

        public async static Task GetResultApiAsync(double valor)
        {
            using (var client = new HttpClient())
            {
                var html = await client.GetStringAsync($"http://localhost:60818/api/operacao/{valor}");
                Console.WriteLine(html); 
            }
        }
    }
}
