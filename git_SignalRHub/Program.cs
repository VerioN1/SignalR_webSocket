using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin.Hosting;

namespace SignalRHub
{
    class Program
    {
        static void Main(string[] args)
        {
           

            using (WebApp.Start<Startup>("http://localhost:1998/hub"))
            {
                Console.WriteLine("Running");
                Console.ReadLine();
                
            }
        }
    }
    [HubName("echo")]
    public class EchoHub : Hub
    {
        public void IncomingMessage(string message)
        {
            Clients.Others.addMessage(message);
            
        }
        public override Task OnConnected()
        {
            Trace.WriteLine(Context.ConnectionId, "have connected!");
            return base.OnConnected();
        }
    }
}
