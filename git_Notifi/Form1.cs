using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using Tulpep.NotificationWindow;
using System.Drawing;
using System.Net.Http;

namespace NotifierPopUp18._09._20
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            

        }
        
        public void Alert2(string msg)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.ContentFont = new System.Drawing.Font("Tahoma", 12F);
            popup.ContentText = msg;
            popup.Size = new Size(400, 100);
            popup.BodyColor = Color.Firebrick;
            popup.HeaderColor = Color.FromArgb(252, 164, 2);
            popup.AnimationDuration = 1022;
            popup.AnimationInterval = 1;
            popup.Popup();
        }
        public void Alert(string msg)
        {
            Form_Alret fa = new Form_Alret();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
       
        private async void conBut_Click(object sender, EventArgs e)
        {
            var hubConnection = new HubConnection("http://localhost:1998/hub");
            var hub = hubConnection.CreateHubProxy("echo");
            hubConnection.Start().Wait();

            await hub.Invoke("IncomingMessage", "Hello , Im Alon");
            IncomList.Items.Add("connected!");
            hub.On<string>("addMessage", param => {
                this.Invoke((Action)(() => {
                    IncomList.Items.Add(param);
                    this.Alert2(param);
                   
                    
                }));
              

            });
        }
    }
}
