using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YK_47_Port_Scanner.Entities;

namespace YK_47_Port_Scanner
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }
        #region UserInterfaceEvents
        private void btnVictimAdd_Click(object sender, EventArgs e)
        {
            VictimAdd(txtVictim.Text);
            txtVictim.Text = "";
        }

        private void VictimAdd(string Value)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(Value);
                listVictims.Items.Add(ipAddress.ToString());
            }
            catch (Exception)
            {
                try
                {
                    IPAddress[] address = Dns.GetHostAddresses(Value);
                    foreach (IPAddress ipAddress in address)
                        listVictims.Items.Add(ipAddress.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Hedef eklenemedi :(\n Değer :" + Value.ToString());
                }
            }
        }

        private void btnSelectedVictimRemove_Click(object sender, EventArgs e)
        {
            if (listVictims.SelectedIndex != -1)
                listVictims.Items.RemoveAt(listVictims.SelectedIndex);
        }

        private void btnVictimInport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string value = sr.ReadLine();
                while (value != null && value != "")
                {
                    VictimAdd(value);
                    value = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }

        private void btnVictimExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string item in listVictims.Items)
                    sw.WriteLine(item);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void btnPortAdd_Click(object sender, EventArgs e)
        {
            listPort.Items.Add(numericPortAdd.Value);
        }

        private void PortAdd(string Port)
        {
            try
            {
                int port = Convert.ToInt32(Port);
                if (port > 0 && port < 65536)
                    listPort.Items.Add(port);
            }
            catch (Exception)
            {
                MessageBox.Show("Port olarak verilen değer eklenemedi !\n Değer:" + Port.ToString());
            }
        }

        private void btnSelectedPortRemove_Click(object sender, EventArgs e)
        {
            if (listPort.SelectedIndex != -1)
                listPort.Items.RemoveAt(listPort.SelectedIndex);
        }

        private void btnPortInport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file (*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath+"\\Data";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string value = sr.ReadLine();
                while (value != null && value != "")
                {
                    PortAdd(value);
                    value = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }

        private void btnPortExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listPort.Items)
                    sw.WriteLine(item.ToString());
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void radioInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInterval.Checked)
            {
                pnlInterval.Visible = true;
                pnlList.Visible = false;
            }
            else
            {
                pnlInterval.Visible = false;
                pnlList.Visible = true;
            }
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (listVictims.Items.Count == 0)
            {
                MessageBox.Show("Lütfen taranacak hedefleri ekleyin!","Hata !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (radioList.Checked && listPort.Items.Count == 0)
            {
                MessageBox.Show("Lütfen taranacak portları ekleyin yada tarama türünü aralık yapın.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openList = new List<IPEndPoint>();
            victimsUpdate();
            label7.Text = "Hedef Sayısı : " + victims.Count.ToString();
            listBox1.Items.Add(string.Format("{0,15}{1,15}{2,15}{3,15}", "Address", "Port", "Status", "Servis"));

            listBox1.Items.Add("");
            progressBar1.Value = 0;
            Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnlList.Visible = false;
            portCommentUpdate();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        private void victimsUpdate()
        {

            victims = new List<IPEndPoint>();
            if (radioInterval.Checked)
            {
                foreach (var victim in listVictims.Items)
                    for (int port = Convert.ToInt32(numericIntervalMin.Value);
                        port <= Convert.ToInt32(numericIntervalMax.Value);
                        port++)
                        victims.Add(new IPEndPoint(IPAddress.Parse(victim.ToString()), Convert.ToInt32(port)));
            }
            else
            {
                foreach (var victim in listVictims.Items)
                    foreach (var port in listPort.Items)
                        victims.Add(new IPEndPoint(IPAddress.Parse(victim.ToString()), Convert.ToInt32(port)));
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = victims.Count;
        }
        private void Start()
        {
            threads = new Thread[victims.Count()];
            foreach (IPEndPoint item in victims)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(VictimConnect));
                thread.Start(new IPEndPointAndIndex() { ipAndPort = item, index = victims.IndexOf(item) });
                threads[victims.IndexOf(item)] = thread;
                progressBar1.Value += 1;
            }
        }

        private void VictimConnect(object value)
        {
            IPEndPointAndIndex _value = (IPEndPointAndIndex)value;
            IPEndPoint address = _value.ipAndPort;
            string ip = address.Address.ToString();
            int port = address.Port;
            string status = "Kapalı";
            TcpClient tclient = new TcpClient();
            try
            {
                tclient.Connect(address);
                if (tclient.Connected == true)
                {
                    openList.Add(address);
                    status = "Açık";
                    listBox1.Items.Add(string.Format("{0,15}{1,15}{2,15}{3,15}", ip, port, status, service(port)));
                }
                else
                {
                    status = "Kapalı/Filtreli";
                    listBox1.Items.Add(string.Format("{0,15}{1,15}{2,15}{3,15}", ip, port, status, service(port)));
                }
            }
            catch (Exception)
            {
                status = "Kapalı";
            }
            Thread.Sleep(200);
        }

        List<PortAndComment> portComment;

        private void portCommentUpdate()
        {
            portComment = new List<PortAndComment>();
            FileStream fs = new FileStream("Data\\portsComment.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string value = sr.ReadLine();
            while (value != null && value != "")
            {
                string[] err = value.Split('=');
                PortAndComment comm = new PortAndComment();
                comm.Comment = err[1];
                try
                {
                    comm.Port = Convert.ToInt32(err[0]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data içerisindeki portsComment.txt dosyanızda bir hata var lütfen kontrol edin.");
                    break;
                }
                portComment.Add(comm);
                value = sr.ReadLine();
            }
        }
        private string service(int port)
        {
            foreach (PortAndComment item in portComment)
                if (item.Port == port)
                    return item.Comment;
            return "Bilmiyorum";
        }
        List<IPEndPoint> openList;
        List<IPEndPoint> victims;
        Thread[] threads;

        private void btnResultExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listBox1.Items)
                    sw.WriteLine(item.ToString());
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
    }
}
