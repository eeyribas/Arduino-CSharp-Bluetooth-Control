using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string serialPort in SerialPort.GetPortNames())
                comboBox1.Items.Add(serialPort);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte[] sendData = BitConverter.GetBytes(20);
                serialPort1.Write(sendData, 0, 4);
                serialPort1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            byte[] sendData = BitConverter.GetBytes(trackBarValue);
            serialPort1.Write(sendData, 0, 4);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int trackBarValue = trackBar2.Value;
            byte[] sendData = BitConverter.GetBytes(trackBarValue + 20);
            serialPort1.Write(sendData, 0, 4);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int trackBarValue = 20;
            byte[] sendData = BitConverter.GetBytes(trackBarValue);
            serialPort1.Write(sendData, 0, 4);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            if (radioButton1.Checked == true)
            {
                byte[] sendData = BitConverter.GetBytes(trackBarValue);
                serialPort1.Write(sendData, 0, 4);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBar2.Value;
            if (radioButton2.Checked == true)
            {
                byte[] sendData = BitConverter.GetBytes(trackBarValue);
                serialPort1.Write(sendData, 0, 4);
            }
        }
    }
}
