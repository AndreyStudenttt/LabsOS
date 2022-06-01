using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Manager : Form
    {
        
        public Manager()
        {
            InitializeComponent();
        }
        Socket serverSocket;
        List<Client> clients = new List<Client>();
        private static byte[] buffer = new byte[8192];
        private void StartServer_Click(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 1234);
            serverSocket.Bind(ep);
            serverSocket.Listen(0);
            checkBoxSost.Checked = true;
            serverSocket.BeginAccept(new AsyncCallback(AcceptClients), null);
        }
        private void AcceptClients(IAsyncResult ar)
        {
            Socket client = serverSocket.EndAccept(ar);
            Client temp = new Client();
            temp.socket = client;
            temp.buffer = new byte[8192];
            clients.Add(temp);
            serverSocket.BeginAccept(new AsyncCallback(AcceptClients), null);
            client.BeginReceive(temp.buffer, 0, temp.buffer.Length, SocketFlags.None, new AsyncCallback(DataRecieve), temp);
        }
        public void DataRecieve(IAsyncResult ar)
        {
            try
            {
                Client cl = (Client)ar.AsyncState;
                Socket socket = cl.socket;
                socket.EndReceive(ar);
                bool part1 = socket.Poll(1000, SelectMode.SelectRead);
                bool part2 = (socket.Available == 0);
                if (part1 && part2)
                {
                    string receiveMassage = cl.Nick + " left chat";
                    clients.Remove(cl);
                    cl.socket.Shutdown(SocketShutdown.Both);
                    byte[] bufferTemp = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine + receiveMassage);
                    foreach (Client c in clients)
                    {
                        c.socket.BeginSend(bufferTemp, 0, bufferTemp.Length, SocketFlags.None, new AsyncCallback(DataSend), c.socket);
                    }
                    return;
                }


                if (String.IsNullOrWhiteSpace(System.Text.Encoding.UTF8.GetString(cl.buffer).TrimEnd('\0'))) { }
                else if (String.IsNullOrWhiteSpace(cl.Nick))
                {
                    string clientName = System.Text.Encoding.UTF8.GetString(cl.buffer);
                    clientName = clientName.TrimEnd('\0');
                    cl.Nick = clientName;
                    clientName = "<<< " + cl.Nick + " join chat >>>".Replace(Environment.NewLine, "");
                    byte[] bufferTemp = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine + clientName);
                    foreach (Client c in clients)
                    {
                        c.socket.BeginSend(bufferTemp, 0, bufferTemp.Length, SocketFlags.None, new AsyncCallback(DataSend), c.socket);
                    }
                }
                else
                {
                    string receiveMassage = cl.GetNick() + System.Text.Encoding.UTF8.GetString(cl.buffer);
                    byte[] bufferTemp = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine + receiveMassage);
                    foreach (Client c in clients)
                    {
                        c.socket.BeginSend(bufferTemp, 0, bufferTemp.Length, SocketFlags.None, new AsyncCallback(DataSend), c.socket);
                    }
                }
                cl.buffer = new byte[8192];
                socket.BeginReceive(cl.buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(DataRecieve), cl);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void DataSend(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                socket.EndSend(ar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            
        }

        

        private void checkBoxSost_Click(object sender, EventArgs e)
        {
            switch (checkBoxSost.Checked)
            {
            case true:
                    checkBoxSost.Checked = false;
                    break;
                    case false:
                    checkBoxSost.Checked = true;
                    break;
            }

        }
    }
}
