namespace @interface
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
            this.connectbutton = new System.Windows.Forms.Button();
            this.disconbutton = new System.Windows.Forms.Button();
            this.onbutton = new System.Windows.Forms.Button();
            this.offbutton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pin8on = new System.Windows.Forms.Button();
            this.pin8off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(23, 30);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(179, 67);
            this.connectbutton.TabIndex = 0;
            this.connectbutton.Text = "connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // disconbutton
            // 
            this.disconbutton.Location = new System.Drawing.Point(23, 122);
            this.disconbutton.Name = "disconbutton";
            this.disconbutton.Size = new System.Drawing.Size(179, 87);
            this.disconbutton.TabIndex = 1;
            this.disconbutton.Text = "discon";
            this.disconbutton.UseVisualStyleBackColor = true;
            this.disconbutton.Click += new System.EventHandler(this.disconbutton_Click);
            // 
            // onbutton
            // 
            this.onbutton.Location = new System.Drawing.Point(257, 30);
            this.onbutton.Name = "onbutton";
            this.onbutton.Size = new System.Drawing.Size(177, 49);
            this.onbutton.TabIndex = 2;
            this.onbutton.Text = "13 on";
            this.onbutton.UseVisualStyleBackColor = true;
            this.onbutton.Click += new System.EventHandler(this.onbutton_Click);
            // 
            // offbutton
            // 
            this.offbutton.Location = new System.Drawing.Point(257, 102);
            this.offbutton.Name = "offbutton";
            this.offbutton.Size = new System.Drawing.Size(177, 68);
            this.offbutton.TabIndex = 3;
            this.offbutton.Text = "13 off";
            this.offbutton.UseVisualStyleBackColor = true;
            this.offbutton.Click += new System.EventHandler(this.offbutton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // pin8on
            // 
            this.pin8on.Location = new System.Drawing.Point(487, 30);
            this.pin8on.Name = "pin8on";
            this.pin8on.Size = new System.Drawing.Size(164, 49);
            this.pin8on.TabIndex = 4;
            this.pin8on.Text = "8 on";
            this.pin8on.UseVisualStyleBackColor = true;
            this.pin8on.Click += new System.EventHandler(this.pin8on_Click);
            // 
            // pin8off
            // 
            this.pin8off.Location = new System.Drawing.Point(487, 102);
            this.pin8off.Name = "pin8off";
            this.pin8off.Size = new System.Drawing.Size(164, 49);
            this.pin8off.TabIndex = 5;
            this.pin8off.Text = "8 off";
            this.pin8off.UseVisualStyleBackColor = true;
            this.pin8off.Click += new System.EventHandler(this.pin8off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 297);
            this.Controls.Add(this.pin8off);
            this.Controls.Add(this.pin8on);
            this.Controls.Add(this.offbutton);
            this.Controls.Add(this.onbutton);
            this.Controls.Add(this.disconbutton);
            this.Controls.Add(this.connectbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Button disconbutton;
        private System.Windows.Forms.Button onbutton;
        private System.Windows.Forms.Button offbutton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button pin8on;
        private System.Windows.Forms.Button pin8off;
    }
}

