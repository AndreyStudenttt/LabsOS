using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread server = new Thread(ServerThread);
           server.Start();
        }
        private void ServerThread()
        {
            NamedPipeServerStream pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.InOut);
            ListConsole.Items.Add("WAIT CONNECT");
            pipeServer.WaitForConnection();
            ListConsole.Items.Add("CONNECTED");




        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Thread.CurrentThread.Abort();
            }
            catch
            {

            }
           
        }
    }
}
