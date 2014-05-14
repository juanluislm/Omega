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

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void startArd()
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                MessageBox.Show("Omega Vest connected successfully");
            }
            else {
                MessageBox.Show("Omega Vest is already connected");
            }
        }

        public void closeArd() {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Omega Vest was disconnected Succesfully");
            }
            else {
                MessageBox.Show("Omega Vest is already disconnected");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void findVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            if (d1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                axWindowsMediaPlayer1.URL = d1.FileName;
            }
            Form3 child = new Form3();
            child.MdiParent = this;
            child.Show();
        }

        private void detectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
