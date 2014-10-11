using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) {
                serialPort1.Open();
                MessageBox.Show("Connected");
            }
        }

        private void disconbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                serialPort1.Close();
                MessageBox.Show("disc");
            }
        }

        private void onbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            serialPort1.Write("131");
        }

        private void offbutton_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            serialPort1.Write("130");
        }

        private void pin8on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("091");
        }

        private void pin8off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("090");
        }


    }
}
