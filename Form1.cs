using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArduinoController
{
    public partial class ArdunioController : Form
    {
        bool connected = false;
        String[] ports;
        SerialPort port;
       
        //ino file generator class, not used yet.
        INOGenerator ino = new INOGenerator();


        public ArdunioController()
        {       
            InitializeComponent();
            DisableControls();
            GenerateCOMUI(); 
        }

        private void GenerateCOMUI()
        {
            //Ports
            ports = SerialPort.GetPortNames();
            
            foreach (string port in ports)
            {
                cboSerialConnection.Items.Add(port);
                if (ports[0] != null)
                {
                    cboSerialConnection.SelectedItem = ports[0];
                }
            }
            if (ports.Length == 0)
            {
                btnConnect.Enabled = false;
            }

            //Baud
            int[] baudRates = { 300, 600, 1200, 2400, 4800,
                9600, 14400, 19200, 28800, 38400, 57600 };

            foreach (int baudRate in baudRates)
            {
                cboBaudRate.Items.Add(baudRate);
            }

            //Parity
            string[] parityOptions = { "None", "Even", "Odd" };

            foreach (string parityOption in parityOptions)
            {
                cboParity.Items.Add(parityOption);
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }

        private void Connect()
        {
            connected = true;
            string selectedPort = cboSerialConnection.GetItemText(cboSerialConnection.SelectedItem);
            string baudRate = cboBaudRate.GetItemText(cboBaudRate.SelectedItem);
            int bRate = Int32.Parse(baudRate);

            port = new SerialPort(selectedPort, bRate, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            btnConnect.Text = "Disconnect";
            EnableControls();

        }

        //LEDS will be grouped into one function in future
        private void chkLED1_CheckedChanged(object sender, EventArgs e)
        {
            int LEDID = 1;
            bool check = false;

            if (chkLED1.Checked)
                check = true;

            LEDControl(LEDID, check);
        }

        private void chkLED2_CheckedChanged(object sender, EventArgs e)
        {
            int LEDID = 2;
            bool check = false;

            if (chkLED2.Checked)
                check = true;

            LEDControl(LEDID, check);
        }

        private void chkLED3_CheckedChanged(object sender, EventArgs e)
        {
            int LEDID = 3;
            bool check = false;

            if (chkLED3.Checked)
                check = true;

            LEDControl(LEDID, check);
        }

        private void LEDControl(int LEDID, bool Checked)
        {
            if (connected)
            {
                if (Checked == true)
                {
                    port.Write("#LED" + LEDID + "ON\n");
                }
                else
                {
                    port.Write("#LED" + LEDID + "OF\n");
                }
            }
        }
        private void Disconnect()
        {
            connected = false;
            port.Write("#STOP\n");
            port.Close();
            btnConnect.Text = "Connect";
            DisableControls();
            ResetDefaults();
        }

        private void EnableControls()
        {
            //COMS
            cboSerialConnection.Enabled = false;
            cboParity.Enabled = false;
            cboBaudRate.Enabled = false;

            //Checkboxes
            foreach (CheckBox c in groupBoxLED.Controls.OfType<CheckBox>())
            {
                c.Enabled = true;
            }

            //LCD
            btnWriteLCD.Enabled = true;
            txtLCDControl.Enabled = true;
        }


        private void DisableControls()
        {
            //COMS
            cboSerialConnection.Enabled = true;
            cboParity.Enabled = true;
            cboBaudRate.Enabled = true;
            
            //Checkboxes
            foreach(CheckBox c in groupBoxLED.Controls.OfType<CheckBox>())
            {
                c.Enabled = false;
            }

            //LCD
            btnWriteLCD.Enabled = false;
            txtLCDControl.Enabled = false;

        }

        private void ResetDefaults()
        {
            txtLCDControl.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLCDClear_Click(object sender, EventArgs e)
        {
            txtLCDControl.Text = "";
        }
    }

 
}


