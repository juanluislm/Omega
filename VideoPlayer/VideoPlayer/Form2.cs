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
    public partial class Form2 : Form
    {
        Form1 dummyForm1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dummyForm1.startArd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dummyForm1.closeArd();
        }
    }
}
