using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testnewinformation
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        static EventWaitHandle handle = new AutoResetEvent(false);
        
        int x;
        private void ButTEST_Click(object sender, EventArgs e)
        {
            //Запуск потока
            new Thread(Run).Start();
            //Ожидание...
            TBTest.Text = "WAit";
            handle.WaitOne();
            //Получили сигнал!
            TBTest.Text = "getsignal";

           
        }
        void Run()
        {
            //Ждем...
            Thread.Sleep(3000);
            //Сигналим о завершении
            handle.Set();
        }
    }
}
    