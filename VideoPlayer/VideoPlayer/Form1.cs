using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        string csvname;
        int listposition = 0;
        string[] listContent;
        List<string> testParse;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Omega Player"; //Name of form
        }

        public void startArd()
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

        public void closeArd() {
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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
                if(File.Exists(csvname)) testParse = parseCSV(csvname);
                timer2.Enabled = true;
                timer2.Start();
                timer2.Interval = 200;
                axWindowsMediaPlayer1.URL = d1.FileName;
            }
        }

        private void detectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.ShowDialog();
            //child.MdiParent = this;
            //child.BringToFront();
            //child.Show();
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startArd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                return;
            }
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                serialPort1.Write("080");
                serialPort1.Write("130");
                return;
            }
            int cursorPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            //textBox1.Text = cursorPosition.ToString(); //DateTime.Now.ToString("HH:mm:ss");
            //we are going to compare
            listContent = testParse[listposition].Split(',');
            int upper = convertTimeToSec_7(listContent[1]);
            int lower = convertTimeToSec_7(listContent[0]);
            int current = cursorPosition;
            /* if (cursorPosition.Length <=6 && cursorPosition.Length>2){
                current = convertTimeToSec_5(cursorPosition);
            }else if(cursorPosition.Length>=7){
                current = convertTimeToSec_7(cursorPosition);
            }else{
                current = convertTimeToSec_2(cursorPosition);
            }*/
            if (upper >= current && lower <= current)
            { 
                //send messages
                serialPort1.Write(listContent[2]);
                serialPort1.Write(listContent[3]);
            }
            else if (current > upper)
            {
                if (listposition < testParse.Capacity)
                {
                    while (current > upper)
                    {
                        listposition++;
                        listContent = testParse[listposition].Split(',');
                        upper = convertTimeToSec_7(listContent[1]);
                        lower = convertTimeToSec_7(listContent[0]);
                        if (listposition == testParse.Capacity) break;
                    }
                    serialPort1.Write(listContent[2]);
                    serialPort1.Write(listContent[3]);
                }
            }
            else if (current < lower)
            {
                if (listposition >= 0)
                {
                    while (lower > current)
                    {
                        listposition--;
                        listContent = testParse[listposition].Split(',');
                        upper = convertTimeToSec_7(listContent[1]);
                        lower = convertTimeToSec_7(listContent[0]);
                        if (listposition == 0) break;
                    }
                    serialPort1.Write(listContent[2]);
                    serialPort1.Write(listContent[3]);
                }
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

        int convertTimeToSec_7(string someString)
        {
            int timeInSeconds;
            int hour = (someString[0] - '0') * 10 + someString[1] - '0';
            int minute = (someString[3] - '0') * 10 + someString[4] - '0';
            int second = (someString[6] - '0') * 10 + someString[7] - '0';

            timeInSeconds = hour * 3600 + minute * 60 + second;

            return timeInSeconds;
        }

        int convertTimeToSec_5(string someString)
        {
            int timeInSeconds;
             int minute = (someString[0] - '0') * 10 + someString[1] - '0';
            int second = (someString[3] - '0') * 10 + someString[4] - '0';

            timeInSeconds = minute * 60 + second;

            return timeInSeconds;
        }

        int convertTimeToSec_2(string someString)
        {
            int timeInSeconds;
            int second = (someString[1] - '0') * 10 + someString[0] - '0';

            timeInSeconds = second;

            return timeInSeconds;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Write("080");
            serialPort1.Write("130");
            closeArd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pin8l_TextChanged(object sender, EventArgs e)
        {

        }

        private void pin8h_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pin13l_TextChanged(object sender, EventArgs e)
        {

        }

        private void pin13h_TextChanged(object sender, EventArgs e)
        {

        }

        //public static String getFileLine(String path, int indexOfLine)
        //{
        //    return File.ReadLines(path).ElementAtOrDefault(indexOfLine);
            
        //}
    }
}
