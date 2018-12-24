using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Testing_New_Include
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            
            //if nothing is sellected in comboBox1 or 2
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                // print thise    
                textBox2.Text = "Please Select Port Settings";

            }
            else
            {
                //else PortName=text in comboBox1
                serialPort1.PortName = comboBox1.Text;
                // baude rate in combo box was set to int as a text
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                // opens serial port
                serialPort1.Open();
                // sets progress bar to 100%
                progressBar1.Value = 100;
                //enables button1 and button2
                button1.Enabled = true;
                button2.Enabled = true;
                //enables textbox1
                textBox1.Enabled = true;
                //disables button2
                button3.Enabled = false;
                //enable button4
                button4.Enabled = true;

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            progressBar1.Value = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            textBox1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = serialPort1.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
    }
}
