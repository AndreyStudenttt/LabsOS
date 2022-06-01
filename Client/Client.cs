using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Thread client = new Thread(ClientThread);
            client.Start();
        }
        NamedPipeClientStream pipeClient;
        public void ClientThread()
        {
            pipeClient = new NamedPipeClientStream(".", "testpipe",
                        PipeDirection.InOut, PipeOptions.None,
                        TokenImpersonationLevel.Impersonation);
            ListConsole.Items.Add("Client connect...");
            pipeClient.Connect();




        }
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Thread.CurrentThread.Abort();
                
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
