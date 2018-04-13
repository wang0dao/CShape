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
using System.Threading;

namespace SerialPortComm
{
    public partial class MainForm : Form
    {
        #region 数据仿真用

        int sendCnt = 0;
        List<String> dataList = new List<string>();
        List<String> dataListAsiic = new List<String>();
        List<String> dataListDisplay = new List<string>();     

        #endregion

        private delegate void Displaydelegate(byte[] InputBuf);
        private Displaydelegate dispDelegate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dispDelegate = new Displaydelegate(DispReceiveData);
            InitSerailPort();
        }


        /// <summary>
        /// 串口初始化
        /// </summary>
        private void InitSerailPort()
        {
            // 获取所有串口
            String[] ports = SerialPort.GetPortNames();

            if (ports == null || ports.Length == 0)
            {
                if (DialogResult.OK == MessageBox.Show("没有找到串口"))
                {
                    Application.Exit();
                }
            }

            // 串口号
            foreach (String port in ports)
            {
                cboPorts.Items.Add(port);
            }
            cboPorts.SelectedIndex = 0;

            // 波特率
            string[] baundRates = { "110", "300", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "256000" };
            foreach (String baundRate in baundRates)
            {
                cboBaudRates.Items.Add(baundRate);
            }
            cboBaudRates.SelectedItem = "9600";

            // 数据位
            String[] dataBits = { "5", "6", "7", "8" };
            foreach (String dataBit in dataBits)
            {
                cboDataBits.Items.Add(dataBit);
            }
            cboDataBits.SelectedIndex = 3;
        }

        private void InitStatusTool()
        {
            statusPort.Text = "端口：未打开";
        }

        public void DispReceiveData(byte[] InputBuf)
        {

            GetTemperatureData(InputBuf);
            //Encoding encode = Encoding.GetEncoding("GB2312");

            //txtDataView.Text += "接收：";
            //txtDataView.Text += encode.GetString(InputBuf);
            //txtDataView.Text += (" (" + DateTime.Now.ToString("mm:dd:ss") + ")" + "\r\n");
        }

        private void btnPortSwitch_Click(object sender, EventArgs e)
        {
            if (btnPortSwitch.Text == "打开串口")
            {
                if (!checkPortSetting()) return;

                serialPort.PortName = cboPorts.Text;
                serialPort.BaudRate = int.Parse(cboBaudRates.Text);
                serialPort.DataBits = int.Parse(cboDataBits.Text);

                serialPort.Open();

                btnPortSwitch.Text = "关闭串口";
                groupSettings.Enabled = false;
            }
            else
            {
                serialPort.Close();
                btnPortSwitch.Text = "打开串口";
                groupSettings.Enabled = true;
                timSend.Enabled = false;
            }
        }

        private bool checkPortSetting()
        {
            bool check = true;

            if (cboPorts.Text == "" || cboBaudRates.Text == "" || cboDataBits.Text == "")
            {
                MessageBox.Show("请先设置串口！", "RS232串口通信");
                check = false;
            }

            return check;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");

                serialPort.Write(txtDataSend.Text + "\r\n");//发送数据
                txtDataView.Text += "发送：";
                txtDataView.Text += txtDataSend.Text;
                txtDataView.Text += (" (" + DateTime.Now.ToString("mm:dd:ss") + ")" + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                Byte[] InputBuf = new Byte[128];

                serialPort.Read(InputBuf, 0, serialPort.BytesToRead);
                System.Threading.Thread.Sleep(50);
                this.Invoke(dispDelegate, InputBuf);
            }
        }

        private byte[] CreateSimularData()
        {
            byte[] data = { };
            return data;
        }

             
        /// <summary>
        /// 模拟温度传感器
        /// 输出电压：2-6伏
        /// 测量温度：0-100度
        /// 采样精度：8位（即测量范围内有256个刻度）
        /// 例：假设测量的温度是40度，则输出电压=2+4*(40/100)=3.6V
        ///     需要传输的十进制值 = 256*(40/100)=102（取整），二进制：01100110
        /// 数据：20-60度，将50度标为临界值，当达到此温度时，进行警报
        /// </summary>
        private void CreateTemperatureData()
        {
            byte[] by = new byte[1];

            Random r = new Random();
            int start = (int)(256 * (20 / 100.0));
            int end = (int)(256 * 50 / 100.0);
            int asiicData = r.Next(start, end);
            byte data = Convert.ToByte(asiicData);
            by[0] = data;

            dataListAsiic.Add(asiicData.ToString());
            dataList.Add(Encoding.GetEncoding("GB2312").GetString(by));
            dataListDisplay.Add(Math.Ceiling((100 * (asiicData / 256.0))).ToString());
        }


        private void timSend_Tick(object sender, EventArgs e)
        {
            CreateTemperatureData();

            serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");
            serialPort.Write(dataList[sendCnt] + "\r\n");
            txtSimData.Text += (dataListDisplay[sendCnt] + " ");
            sendCnt++;
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            //timSend.Enabled = true;
            CreateTemperatureData();

            serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");
            serialPort.Write(dataList[sendCnt] + "\r\n");
            txtSimData.Text += (dataListDisplay[sendCnt] + " ");
            sendCnt++;
        }

        private void GetTemperatureData(byte[] InputBuf)
        {
            String data = Math.Ceiling((100 * (Convert.ToInt32(InputBuf[0]) / 256.0))).ToString();
            
            txtDataView.Text += "接收：";
            txtDataView.Text += data;
            txtDataView.Text += (" (" + DateTime.Now.ToString("mm:dd:ss") + ")" + "\r\n");
        }
    }
}
