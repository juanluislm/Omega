using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
             foreach (string PortName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(PortName);
            }

        }
    }
}
