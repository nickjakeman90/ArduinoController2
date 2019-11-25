namespace ArduinoController
{
    partial class ArdunioController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLED = new System.Windows.Forms.GroupBox();
            this.cboLED2Port = new System.Windows.Forms.ComboBox();
            this.cboLED1Port = new System.Windows.Forms.ComboBox();
            this.chkLED5 = new System.Windows.Forms.CheckBox();
            this.chkLED4 = new System.Windows.Forms.CheckBox();
            this.chkLED3 = new System.Windows.Forms.CheckBox();
            this.chkLED2 = new System.Windows.Forms.CheckBox();
            this.chkLED1 = new System.Windows.Forms.CheckBox();
            this.txtLCDControl = new System.Windows.Forms.RichTextBox();
            this.btnWriteLCD = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboSerialConnection = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDatabits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLCDClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboLED3Port = new System.Windows.Forms.ComboBox();
            this.cboLED4Port = new System.Windows.Forms.ComboBox();
            this.cboLED5Port = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxLED.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLED
            // 
            this.groupBoxLED.Controls.Add(this.cboLED5Port);
            this.groupBoxLED.Controls.Add(this.cboLED4Port);
            this.groupBoxLED.Controls.Add(this.cboLED3Port);
            this.groupBoxLED.Controls.Add(this.cboLED2Port);
            this.groupBoxLED.Controls.Add(this.cboLED1Port);
            this.groupBoxLED.Controls.Add(this.chkLED5);
            this.groupBoxLED.Controls.Add(this.chkLED4);
            this.groupBoxLED.Controls.Add(this.chkLED3);
            this.groupBoxLED.Controls.Add(this.chkLED2);
            this.groupBoxLED.Controls.Add(this.chkLED1);
            this.groupBoxLED.Location = new System.Drawing.Point(12, 139);
            this.groupBoxLED.Name = "groupBoxLED";
            this.groupBoxLED.Size = new System.Drawing.Size(202, 146);
            this.groupBoxLED.TabIndex = 3;
            this.groupBoxLED.TabStop = false;
            this.groupBoxLED.Text = "LED Controls";
            // 
            // cboLED2Port
            // 
            this.cboLED2Port.FormattingEnabled = true;
            this.cboLED2Port.Location = new System.Drawing.Point(71, 42);
            this.cboLED2Port.Name = "cboLED2Port";
            this.cboLED2Port.Size = new System.Drawing.Size(33, 21);
            this.cboLED2Port.TabIndex = 18;
            // 
            // cboLED1Port
            // 
            this.cboLED1Port.FormattingEnabled = true;
            this.cboLED1Port.Location = new System.Drawing.Point(71, 20);
            this.cboLED1Port.Name = "cboLED1Port";
            this.cboLED1Port.Size = new System.Drawing.Size(33, 21);
            this.cboLED1Port.TabIndex = 17;
            // 
            // chkLED5
            // 
            this.chkLED5.AutoSize = true;
            this.chkLED5.Location = new System.Drawing.Point(11, 114);
            this.chkLED5.Name = "chkLED5";
            this.chkLED5.Size = new System.Drawing.Size(56, 17);
            this.chkLED5.TabIndex = 4;
            this.chkLED5.Text = "LED 5";
            this.chkLED5.UseVisualStyleBackColor = true;
            // 
            // chkLED4
            // 
            this.chkLED4.AutoSize = true;
            this.chkLED4.Location = new System.Drawing.Point(11, 91);
            this.chkLED4.Name = "chkLED4";
            this.chkLED4.Size = new System.Drawing.Size(56, 17);
            this.chkLED4.TabIndex = 3;
            this.chkLED4.Text = "LED 4";
            this.chkLED4.UseVisualStyleBackColor = true;
            // 
            // chkLED3
            // 
            this.chkLED3.AutoSize = true;
            this.chkLED3.Location = new System.Drawing.Point(11, 68);
            this.chkLED3.Name = "chkLED3";
            this.chkLED3.Size = new System.Drawing.Size(56, 17);
            this.chkLED3.TabIndex = 2;
            this.chkLED3.Text = "LED 3";
            this.chkLED3.UseVisualStyleBackColor = true;
            // 
            // chkLED2
            // 
            this.chkLED2.AutoSize = true;
            this.chkLED2.Location = new System.Drawing.Point(11, 45);
            this.chkLED2.Name = "chkLED2";
            this.chkLED2.Size = new System.Drawing.Size(56, 17);
            this.chkLED2.TabIndex = 1;
            this.chkLED2.Text = "LED 2";
            this.chkLED2.UseVisualStyleBackColor = true;
            // 
            // chkLED1
            // 
            this.chkLED1.AutoSize = true;
            this.chkLED1.Location = new System.Drawing.Point(11, 22);
            this.chkLED1.Name = "chkLED1";
            this.chkLED1.Size = new System.Drawing.Size(56, 17);
            this.chkLED1.TabIndex = 0;
            this.chkLED1.Text = "LED 1";
            this.chkLED1.UseVisualStyleBackColor = true;
            this.chkLED1.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
            // 
            // txtLCDControl
            // 
            this.txtLCDControl.Location = new System.Drawing.Point(9, 38);
            this.txtLCDControl.Name = "txtLCDControl";
            this.txtLCDControl.Size = new System.Drawing.Size(193, 75);
            this.txtLCDControl.TabIndex = 4;
            this.txtLCDControl.Text = "";
            // 
            // btnWriteLCD
            // 
            this.btnWriteLCD.Location = new System.Drawing.Point(127, 117);
            this.btnWriteLCD.Name = "btnWriteLCD";
            this.btnWriteLCD.Size = new System.Drawing.Size(75, 23);
            this.btnWriteLCD.TabIndex = 5;
            this.btnWriteLCD.Text = "Write";
            this.btnWriteLCD.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(330, 86);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboSerialConnection
            // 
            this.cboSerialConnection.FormattingEnabled = true;
            this.cboSerialConnection.Location = new System.Drawing.Point(82, 19);
            this.cboSerialConnection.Name = "cboSerialConnection";
            this.cboSerialConnection.Size = new System.Drawing.Size(121, 21);
            this.cboSerialConnection.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStopBits);
            this.groupBox2.Controls.Add(this.cboDatabits);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboParity);
            this.groupBox2.Controls.Add(this.cboBaudRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboSerialConnection);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(11, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 115);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Settings";
            // 
            // cboStopBits
            // 
            this.cboStopBits.Enabled = false;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(268, 49);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 16;
            // 
            // cboDatabits
            // 
            this.cboDatabits.Enabled = false;
            this.cboDatabits.FormattingEnabled = true;
            this.cboDatabits.Location = new System.Drawing.Point(268, 19);
            this.cboDatabits.Name = "cboDatabits";
            this.cboDatabits.Size = new System.Drawing.Size(121, 21);
            this.cboDatabits.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stop Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parity:";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(82, 73);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 21);
            this.cboParity.TabIndex = 11;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(82, 46);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baud Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "COM Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter text to display";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLCDClear);
            this.groupBox3.Controls.Add(this.txtLCDControl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnWriteLCD);
            this.groupBox3.Location = new System.Drawing.Point(220, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 146);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LCD Display";
            // 
            // btnLCDClear
            // 
            this.btnLCDClear.Location = new System.Drawing.Point(18, 117);
            this.btnLCDClear.Name = "btnLCDClear";
            this.btnLCDClear.Size = new System.Drawing.Size(75, 23);
            this.btnLCDClear.TabIndex = 10;
            this.btnLCDClear.Text = "Clear";
            this.btnLCDClear.UseVisualStyleBackColor = true;
            this.btnLCDClear.Click += new System.EventHandler(this.btnLCDClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 108);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor Control";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboLED3Port
            // 
            this.cboLED3Port.FormattingEnabled = true;
            this.cboLED3Port.Location = new System.Drawing.Point(71, 64);
            this.cboLED3Port.Name = "cboLED3Port";
            this.cboLED3Port.Size = new System.Drawing.Size(33, 21);
            this.cboLED3Port.TabIndex = 19;
            // 
            // cboLED4Port
            // 
            this.cboLED4Port.FormattingEnabled = true;
            this.cboLED4Port.Location = new System.Drawing.Point(71, 87);
            this.cboLED4Port.Name = "cboLED4Port";
            this.cboLED4Port.Size = new System.Drawing.Size(33, 21);
            this.cboLED4Port.TabIndex = 20;
            // 
            // cboLED5Port
            // 
            this.cboLED5Port.FormattingEnabled = true;
            this.cboLED5Port.Location = new System.Drawing.Point(71, 110);
            this.cboLED5Port.Name = "cboLED5Port";
            this.cboLED5Port.Size = new System.Drawing.Size(33, 21);
            this.cboLED5Port.TabIndex = 21;
            // 
            // ArdunioController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLED);
            this.Name = "ArdunioController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Controller";
            this.groupBoxLED.ResumeLayout(false);
            this.groupBoxLED.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxLED;
        private System.Windows.Forms.CheckBox chkLED2;
        private System.Windows.Forms.CheckBox chkLED1;
        private System.Windows.Forms.RichTextBox txtLCDControl;
        private System.Windows.Forms.Button btnWriteLCD;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboSerialConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDatabits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkLED5;
        private System.Windows.Forms.CheckBox chkLED4;
        private System.Windows.Forms.CheckBox chkLED3;
        private System.Windows.Forms.Button btnLCDClear;
        private System.Windows.Forms.ComboBox cboLED2Port;
        private System.Windows.Forms.ComboBox cboLED1Port;
        private System.Windows.Forms.ComboBox cboLED5Port;
        private System.Windows.Forms.ComboBox cboLED4Port;
        private System.Windows.Forms.ComboBox cboLED3Port;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

