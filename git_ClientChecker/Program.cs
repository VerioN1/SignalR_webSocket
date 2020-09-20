using System;
using Tulpep.NotificationWindow;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PopUpCheck2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Do().Wait();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static async Task<string> FetchData(string url)
        {
            var httpClient = HttpClientFactory.Create();
            var response = await httpClient.GetStringAsync(url);
            DeSerial data = JsonConvert.DeserializeObject<DeSerial>(response);

            Console.WriteLine(data.title);
            return data.title;

        }
        public class DeSerial
        {
            public string userId { get; set; }
            public string id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }

        public static void AsColorFor(ConsoleColor color, Action action)
        {
            Console.ForegroundColor = color;
            action();
            Console.ResetColor();
        }
        static async Task Do()
        {
            var url = "http://localhost:1998/hub";
            var connection = new HubConnection(url);
            var hub = connection.CreateHubProxy("echo");
            await connection.Start();

            await hub.Invoke("IncomingMessage", "connected");
           
            hub.On<string>("addMessage", param => {
                Console.WriteLine(param);
            });
            var input = "true";
            while (input != "n")
            {
                input = Console.ReadLine();
                var warning = await FetchData("https://jsonplaceholder.typicode.com/posts/1");
                await hub.Invoke("IncomingMessage", warning);
            }
           
            if (connection.State == ConnectionState.Disconnected)
            {
                try
                {
                    var response = await hub.Invoke<string>("IncomingMessage",
                    "hello!");
                    Console.WriteLine("Said: {0}", response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting: {0}", ex);
                }
            }
        }
    }

}
