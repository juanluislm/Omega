namespace VideoPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omegaVestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pin8l = new System.Windows.Forms.TextBox();
            this.pin8h = new System.Windows.Forms.TextBox();
            this.pin13l = new System.Windows.Forms.TextBox();
            this.pin13h = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(666, 461);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findVideoToolStripMenuItem,
            this.omegaVestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findVideoToolStripMenuItem
            // 
            this.findVideoToolStripMenuItem.Name = "findVideoToolStripMenuItem";
            this.findVideoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.findVideoToolStripMenuItem.Text = "Find Video";
            this.findVideoToolStripMenuItem.Click += new System.EventHandler(this.findVideoToolStripMenuItem_Click);
            // 
            // omegaVestToolStripMenuItem
            // 
            this.omegaVestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectToolStripMenuItem,
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.omegaVestToolStripMenuItem.Name = "omegaVestToolStripMenuItem";
            this.omegaVestToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.omegaVestToolStripMenuItem.Text = "Omega Vest";
            // 
            // detectToolStripMenuItem
            // 
            this.detectToolStripMenuItem.Name = "detectToolStripMenuItem";
            this.detectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detectToolStripMenuItem.Text = "Detect";
            this.detectToolStripMenuItem.Click += new System.EventHandler(this.detectToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pin8l
            // 
            this.pin8l.Location = new System.Drawing.Point(673, 100);
            this.pin8l.Name = "pin8l";
            this.pin8l.Size = new System.Drawing.Size(100, 20);
            this.pin8l.TabIndex = 3;
            // 
            // pin8h
            // 
            this.pin8h.Location = new System.Drawing.Point(673, 127);
            this.pin8h.Name = "pin8h";
            this.pin8h.Size = new System.Drawing.Size(100, 20);
            this.pin8h.TabIndex = 4;
            // 
            // pin13l
            // 
            this.pin13l.Location = new System.Drawing.Point(673, 154);
            this.pin13l.Name = "pin13l";
            this.pin13l.Size = new System.Drawing.Size(100, 20);
            this.pin13l.TabIndex = 5;
            // 
            // pin13h
            // 
            this.pin13h.Location = new System.Drawing.Point(673, 181);
            this.pin13h.Name = "pin13h";
            this.pin13h.Size = new System.Drawing.Size(100, 20);
            this.pin13h.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 487);
            this.Controls.Add(this.pin13h);
            this.Controls.Add(this.pin13l);
            this.Controls.Add(this.pin8h);
            this.Controls.Add(this.pin8l);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omegaVestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox pin8l;
        private System.Windows.Forms.TextBox pin8h;
        private System.Windows.Forms.TextBox pin13l;
        private System.Windows.Forms.TextBox pin13h;
    }
}

