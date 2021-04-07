
namespace Colour2Arduino
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.colorWheel1 = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.radOpen = new System.Windows.Forms.RadioButton();
            this.radClose = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.staLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.staConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM5";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(165, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 127);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(243, 26);
            this.txtString.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(261, 127);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 32);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(12, 160);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(329, 259);
            this.colorWheel1.TabIndex = 4;
            this.colorWheel1.Text = "colWheel";
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // lstConsole
            // 
            this.lstConsole.Enabled = false;
            this.lstConsole.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.ItemHeight = 21;
            this.lstConsole.Location = new System.Drawing.Point(347, 36);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(469, 382);
            this.lstConsole.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Response";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portToolStrip
            // 
            this.portToolStrip.Name = "portToolStrip";
            this.portToolStrip.Size = new System.Drawing.Size(89, 29);
            this.portToolStrip.Text = "Port No";
            // 
            // radOpen
            // 
            this.radOpen.AutoSize = true;
            this.radOpen.Location = new System.Drawing.Point(6, 25);
            this.radOpen.Name = "radOpen";
            this.radOpen.Size = new System.Drawing.Size(73, 24);
            this.radOpen.TabIndex = 9;
            this.radOpen.TabStop = true;
            this.radOpen.Text = "Open";
            this.radOpen.UseVisualStyleBackColor = true;
            this.radOpen.CheckedChanged += new System.EventHandler(this.radOpen_CheckedChanged);
            // 
            // radClose
            // 
            this.radClose.AutoSize = true;
            this.radClose.Location = new System.Drawing.Point(85, 25);
            this.radClose.Name = "radClose";
            this.radClose.Size = new System.Drawing.Size(74, 24);
            this.radClose.TabIndex = 10;
            this.radClose.TabStop = true;
            this.radClose.Text = "Close";
            this.radClose.UseVisualStyleBackColor = true;
            this.radClose.CheckedChanged += new System.EventHandler(this.radClose_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.staLabel,
            this.staConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(108, 29);
            this.toolStripDropDownButton1.Text = "COM Port";
            this.toolStripDropDownButton1.ToolTipText = "Com Port";
            // 
            // staLabel
            // 
            this.staLabel.Name = "staLabel";
            this.staLabel.Size = new System.Drawing.Size(44, 25);
            this.staLabel.Text = "Port";
            // 
            // staConnection
            // 
            this.staConnection.Name = "staConnection";
            this.staConnection.Size = new System.Drawing.Size(211, 25);
            this.staConnection.Text = "|   Connection is: CLOSED";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radClose);
            this.groupBox1.Controls.Add(this.radOpen);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 64);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Control";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 33);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 416);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.ControlBox = false;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstConsole);
            this.Controls.Add(this.colorWheel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Colour 2 Arduino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnSend;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel colorWheel1;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portToolStrip;
        private System.Windows.Forms.RadioButton radOpen;
        private System.Windows.Forms.RadioButton radClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel staLabel;
        private System.Windows.Forms.ToolStripStatusLabel staConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

