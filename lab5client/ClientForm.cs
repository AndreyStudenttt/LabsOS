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

namespace lab5client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        public string userName;
        public Socket socket;
        public byte[] buffer = new byte[8192];
        private void ButConnect_Click(object sender, EventArgs e)
        {
            userName = TBNick.Text;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip, 1234);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(ep, new AsyncCallback(ConnectToServer), null);
        }
        private void ConnectToServer(IAsyncResult ar)
        {
            try
            {
                socket.EndConnect(ar);
                byte[] bufferTemp = Encoding.UTF8.GetBytes(userName);
                socket.BeginSend(bufferTemp, 0, bufferTemp.Length, SocketFlags.None, new AsyncCallback(DataSend), null);
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(DataRecieve), null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DataSend(IAsyncResult ar)
        {
            try
            {
                socket.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataRecieve(IAsyncResult ar)
        {
            socket.EndReceive(ar);
            string receiveMassage = System.Text.Encoding.UTF8.GetString(buffer);
            UpdateChat(receiveMassage);
            buffer = new byte[8192];
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(DataRecieve), null);
        }
        private void UpdateChat(string message)
        {
            ConsoleChat.Invoke((MethodInvoker)delegate {
                ConsoleChat.Items.Add(message);
            });
        }

        private void ButSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TBChat.Text)) return;
            byte[] bufferTemp = Encoding.UTF8.GetBytes(TBChat.Text);
            TBChat.Text = null;
            socket.BeginSend(bufferTemp, 0, bufferTemp.Length, SocketFlags.None, new AsyncCallback(DataSend), null);
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
            }
        }
    }
}
