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

namespace SerialPortTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            if (ports == null)
            {
                MessageBox.Show("没有检查到串口","Error");
                return;
            }

            foreach (String port in ports)
            {
                cboPorts.Items.Add(ports);
            }

            cboBaudRate.Items.Add("9600");


        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
