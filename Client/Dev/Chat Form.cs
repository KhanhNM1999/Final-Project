using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dev
{
    public partial class Chat_Form : DevExpress.XtraEditors.XtraForm
    {
        public delegate void NTPRefreshData();

        public class Const
        {
            public static String ipServer
            {
                get
                {
                    string ip = "192.168.43.151";

                    String strHostName = Dns.GetHostName();

                    IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

                    foreach (IPAddress ipaddress in iphostentry.AddressList)
                    {
                        ip = ipaddress.ToString();
                    }

                    return ip;
                }
            }
            public static int port = 8080;
        }

        public Chat_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        StreamReader sr;
        StreamWriter sw;
        string dataReceive = "";

        public void Connect()
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse(Const.ipServer), Const.port);
            TcpClient tcpclient = new TcpClient();

            tcpclient.Connect(ipendpoint);

            sr = new StreamReader(tcpclient.GetStream());
            sw = new StreamWriter(tcpclient.GetStream());

            Task.Run(() => {
                while (true)
                {
                    try
                    {
                        dataReceive = sr.ReadLine();
                        RefreshData();
                    }
                    catch { }
                }

                sr.Close();
                sw.Close();
                tcpclient.Close();
            });
        }

        public void RefreshData()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new NTPRefreshData(RefreshData), new object[] { });
            }
            else
            {
                setText(dataReceive);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            GuiNoiDung();
        }

        void GuiNoiDung()
        {
            string noiDung = tbMess.Text.Replace("\r\n", "");
            if (noiDung.Trim() == "")
            {
                return;
            }

            string datasend = "Client: " + noiDung;
            setText(datasend);

            //int idx = rtbChatLog.Text.IndexOf(datasend);
            //rtbChatLog.Select(idx, datasend.Length);
            //rtbChatLog.SelectionAlignment = HorizontalAlignment.Center;

            sw.WriteLine(datasend);
            sw.Flush();

            tbMess.Text = string.Empty;
            tbMess.Focus();
        }

        void setText(string noiDung)
        {
            if (rtbChatLog.Text != "")
            {
                rtbChatLog.Text += "\r\n";
            }

            rtbChatLog.Text += noiDung;

            //HighlightText(rtbChatLog, "Client:", Color.Blue);
        }

        private void tbMess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GuiNoiDung();
            }
        }

        public void HighlightText(RichTextBox myRtb, string word, Color color)
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = color;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GuiNoiDung();
        }
    }
}