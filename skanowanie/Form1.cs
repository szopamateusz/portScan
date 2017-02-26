using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace skanowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btScann_Click(object sender, EventArgs e)
        {
            short[] portList = {20, 21, 22, 23, 53, 70, 80, 109, 110, 119, 143, 161, 162, 443, 3389};
            string host = tbhostAdress.Text;
            lbMessage.Items.Add("skanowanie portów dla " + host);
            lbMessage.Items.Add("to moze chwile potrwac");
            foreach (var port in portList)
            {
                this.Refresh();
                try
                {
                    TcpClient client = new TcpClient(host, port);
                    lbMessage.Items.Add("port " + port.ToString() + " jest otwarty");
                }
                catch
                {
                    lbMessage.Items.Add("port " + port.ToString() + "jest zamknięty");
                }
            }
        }
    }
}