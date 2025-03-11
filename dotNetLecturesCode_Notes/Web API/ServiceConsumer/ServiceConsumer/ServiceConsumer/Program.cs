using ServiceConsumer.Models;
using System.Net.Http.Json;

namespace ServiceConsumer
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            HttpClient client = new HttpClient();
            Dept d= await client.GetFromJsonAsync<Dept>("http://localhost:5213/api/Department/1");
            Console.WriteLine(d.Name);
        }
    }
}
