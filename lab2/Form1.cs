using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        public byte[] bytearr { get; set; }
        string filename;
        string filenameend;
        string type;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPathOrig_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                type = Path.GetExtension(op.FileName);
                filename = op.FileName;

                textBoxFileStart.Text = filename;

                FileStream fstream = File.OpenRead(filename);
                bytearr = new byte[fstream.Length];
                fstream.Read(bytearr,0, bytearr.Length);
            }
        }

        private void buttonPathCop_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = $"Text documents ({type})|*{type}";

            if (save.ShowDialog() == DialogResult.OK)
            {
                filenameend = save.FileName;
                textBoxFileEnd.Text = filenameend;
            }
        }

        private void buttonCop_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(filenameend, bytearr);
        }
        EventWaitHandle handle = new AutoResetEvent(false);
        private void buttonCopThread_Click(object sender, EventArgs e)
        {
            buttonCopThread.Enabled = false;
            Thread copy = new Thread(CopyThread);
            copy.Start();
           
          handle.WaitOne();
            buttonCopThread.Enabled = true;
        }

        public void CopyThread ()
        {

            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = 0));
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value++));

            }
            //Thread.Sleep(500);
            //File.WriteAllBytes(filenameend, bytearr);
            handle.Set();
        }
    }
}
