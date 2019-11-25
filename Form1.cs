using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArduinoController
{
    public partial class ArdunioController : Form
    {
        private bool connected = false;
        private String[] ports;
        private SerialPort port;
       
        //ino file generator class, not used yet.
        INOGenerator ino = new INOGenerator();


        public ArdunioController()
        {       
            InitializeComponent();
            DisableControls();
            GenerateCOMUI();
            PopulateLEDPorts();
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
            cboBaudRate.DataSource = baudRates;

            //Parity
            cboParity.DataSource = Enum.GetValues(typeof(Parity));

            //Data bits
            int[] dataBits = { 5, 6, 7, 8 };
            cboDatabits.DataSource = dataBits;

            //Stop bits
            cboStopBits.DataSource = Enum.GetValues(typeof(StopBits));


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

            Parity parity;
            Enum.TryParse<Parity>(cboParity.SelectedValue.ToString(), out parity);

            string dataBits = cboDatabits.GetItemText(cboDatabits.SelectedItem);
            int dBits = Int32.Parse(dataBits);

            StopBits stopbits;
            Enum.TryParse<StopBits>(cboStopBits.SelectedValue.ToString(), out stopbits);

            port = new SerialPort(selectedPort, bRate, parity, dBits, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            btnConnect.Text = "Disconnect";
            EnableControls();

        }

        //LEDS will be grouped 
        private void chkLED1_CheckedChanged(object sender, EventArgs e)
        {
            LED LED1 = new LED(1, chkLED1.Checked);
            LEDControl(LED1);
        }

        private void chkLED2_CheckedChanged(object sender, EventArgs e)
        {
            LED LED2 = new LED(2, chkLED2.Checked);
            LEDControl(LED2);
        }

        private void chkLED3_CheckedChanged(object sender, EventArgs e)
        {
            LED LED3 = new LED(3, chkLED3.Checked);
            LEDControl(LED3);
        }

        private void chkLED4_CheckedChanged(object sender, EventArgs e)
        {
            LED LED4 = new LED(4, chkLED4.Checked);
            LEDControl(LED4);
        }

        private void chkLED5_CheckedChanged(object sender, EventArgs e)
        {
            LED LED5 = new LED(5, chkLED5.Checked);
            LEDControl(LED5);
        }

        private void LEDControl(LED lED)
        {
            if (connected)
            {
                if (lED.Active == true)
                {
                    port.Write("#LED" + lED.LEDID + "ON\n");
                }
                else
                {
                    port.Write("#LED" + lED.LEDID + "OF\n");
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
            cboDatabits.Enabled = false;
            cboStopBits.Enabled = false;

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
            cboDatabits.Enabled = true;
            cboStopBits.Enabled = true;
            
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

        private void PopulateLEDPorts()
        {
            foreach (ComboBox c in groupBoxLED.Controls.OfType<ComboBox>())
            {
                for(int i = 0; i < 14; i++)
                c.Items.Add(i);
            }
        }

    }


}


