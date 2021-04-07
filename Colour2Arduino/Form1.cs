using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;


namespace Colour2Arduino
{
    public partial class frmMain : Form
    {
        string strPortNo;
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }
        public void RefreshPorts()
        {
            portToolStrip.DropDownItems.Clear();
            toolStripDropDownButton1.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portToolStrip.DropDownItems.Add(port).Click += MenuItem_Click;
                toolStripDropDownButton1.DropDownItems.Add(port).Click += MenuItem_Click;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            serialPort.WriteLine(txtString.Text);
            // serialPort.Close();

        }


        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Please ensure you have opened the serial connection");
            }
            else
            {
                SendHex();
                System.Threading.Thread.Sleep(1500);
                lstConsole.Items.Add(serialPort.ReadExisting());
                lstConsole.TopIndex = lstConsole.Items.Count - 1;
                //serialPort.Close();
            }
        }
        private void SendHex()
        {
            txtString.Text = ColorTranslator.ToHtml(colorWheel1.Color);
            serialPort.WriteLine(txtString.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            strPortNo = menuItem.Text;
            serialPort.PortName = strPortNo;
            staLabel.Text = strPortNo;
        }

        private void radOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (strPortNo == null)
            {
                MessageBox.Show("You must choose a port first!");
                radClose.Checked = false;
                radOpen.Checked = false;
            }


            else if (radOpen.Checked)
            {
                serialPort.Open();
                lstConsole.Items.Add("Opening Serial Connection...");
                staConnection.Text = "|   Connection is: OPEN";
            }
        }

        private void radClose_CheckedChanged(object sender, EventArgs e)
        {
            if (strPortNo == null)
            {
                MessageBox.Show("You must choose a port first!");
                radClose.Checked = false;
                radOpen.Checked = false;
            }


            else if (radClose.Checked)
            {
                serialPort.Close();
                lstConsole.Items.Add("Serial Connection Closed!");
                staConnection.Text = "|   Connection is: CLOSED";
            }
        }
    }
}

