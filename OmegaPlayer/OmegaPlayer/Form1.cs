using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace OmegaPlayer
{
    public partial class Form1 : Form
    {
        string csvname;
        int listposition = 0;
        float upper = 0;
        float lower = 0;
        float current = 0;
        string[] listContent;
        List<string> testParse;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Omega Player"; //Name of form
        }

        public void openPort()
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                MessageBox.Show("Omega Vest was connected successfully.");
            }
            else
            {
                MessageBox.Show("Omega Vest is already connected.");
            }
        }

        public void closePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Omega Vest was disconnected succesfully.");
            }
            else
            {
                MessageBox.Show("Omega Vest is already disconnected.");
            }
        }

        private void findVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            d1.Filter = "Movie Files|*.wmv|MPEG Files|*.mpeg|Avi Files|*.avi";
            d1.FilterIndex = 1;
            if (d1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csvname = d1.FileName;
                csvname = ReplaceAt(csvname, csvname.Length - 1, 'v');
                csvname = ReplaceAt(csvname, csvname.Length - 2, 's');
                csvname = ReplaceAt(csvname, csvname.Length - 3, 'c');
                if (File.Exists(csvname))
                {
                    MessageBox.Show("Successfully found CSV file. Press OK to start.");
                }
                else //Let user choose to play video when CSV file not found
                {
                    DialogResult dialogResult = MessageBox.Show("CSV file at " + csvname + " is missing.\nDo you still want to play the video without effects?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Continue playing video
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //Do nothing
                        return;
                    }
                }
                if (File.Exists(csvname)) testParse = parseCSV(csvname);
                listContent = testParse[listposition].Split(',');
                upper = convertTimeToSec(listContent[1]);
                lower = convertTimeToSec(listContent[0]);
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 100;
                axWindowsMediaPlayer1.URL = d1.FileName;
            }
        }

        public List<string> parseCSV(string path)
        {
            List<string> parsedData = new List<string>();

            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line;
                    //  row = line.;
                    parsedData.Add(row);
                }
            }

            return parsedData;
        }

        public string ReplaceAt(string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }

        float convertTimeToSec(string someString)
        {
            float timeInSeconds;
            int hour = (someString[0] - '0') * 10 + someString[1] - '0';
            int minute = (someString[3] - '0') * 10 + someString[4] - '0';
            int second = (someString[6] - '0') * 10 + someString[7] - '0';

            timeInSeconds = (float) hour * 3600 + minute * 60 + second;

            return timeInSeconds;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                return;
            }
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
               serialPort1.Write("080");
               serialPort1.Write("130");
               serialPort1.Write("090");
               serialPort1.Write("100");
               return;
            }
            current = (float)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            while (current > upper)
            {
                if (listposition == testParse.Count - 1) break;
                listposition++;
                listContent = testParse[listposition].Split(',');
                lower = convertTimeToSec(listContent[0]);
                upper = convertTimeToSec(listContent[1]);
            }
            while (current < lower)
            {
                if (listposition == 0) break;
                listposition--;
                listContent = testParse[listposition].Split(',');
                lower = convertTimeToSec(listContent[0]);
                upper = convertTimeToSec(listContent[1]);
            }
            while (lower <= current && current <= upper)
            {
                //send messages to Arduino
                serialPort1.Write(listContent[2]);
                serialPort1.Write(listContent[3]);
                //Additional pins
                serialPort1.Write(listContent[4]);
                serialPort1.Write(listContent[5]);
                //serialPort1.Write(listContent[6]);
                //serialPort1.Write(listContent[7]);
                this.label1.Text = "Lower: " + lower + ", Current: " + current + ", Upper: " + upper + " Send: " + listContent[2] + ", " + listContent[3];
                break;
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPort();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePort();
        }
    }
}
