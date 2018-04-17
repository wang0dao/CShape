using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoSharp
{
    public partial class RealChart : Form
    {
        private Queue<double> dataQueue = new Queue<double>(20);
        private Queue<String> xData = new Queue<String>(20);
        private Queue<String> yData = new Queue<String>(20);

        private String fontName = "Microsoft Sans Serif";

        private int curValue = 0;

        private int num = 1;//每次删除增加几个点

        public RealChart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInit_Click(object sender, EventArgs e)
        {
            InitChart();
        }

        /// <summary>
        /// 开始事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        } 
        
        /// <summary>
        /// 停止事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        /// <summary>
        /// 定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for(int i=0;i<dataQueue.Count;i++){
                this.chart1.Series[0].Points.AddXY((xData.ElementAt(i)), dataQueue.ElementAt(i));
            }
            this.chart1.Titles[1].Text = "当前温度:" + dataQueue.ElementAt(dataQueue.Count - 1) + " ℃";
        } 
        
        /// <summary>
        /// 初始化图表
        /// </summary>
        private void InitChart() {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //控件背景
            this.chart1.BackColor = Color.Black;
            //图表区背景
            this.chart1.ChartAreas[0].BackColor = Color.Transparent;
            this.chart1.ChartAreas[0].BorderColor = Color.Transparent;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.White;
            //this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart1.Titles[0].Font = new Font(fontName, 12f, FontStyle.Regular);
            this.chart1.Titles[0].Alignment = ContentAlignment.TopCenter;
            this.chart1.Titles.Add("当前温度:0 ℃");
            this.chart1.Titles[1].ForeColor = Color.White;
            this.chart1.Titles[1].Font = new Font(fontName, 8f, FontStyle.Regular);
            this.chart1.Titles[1].Alignment = ContentAlignment.TopRight;
            //X坐标轴
            this.chart1.ChartAreas[0].AxisX.Interval = 1;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font(fontName, 10f, FontStyle.Regular);
            this.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chart1.ChartAreas[0].AxisX.Title = "实时时间(hh:mm:ss)";
            this.chart1.ChartAreas[0].AxisX.TitleFont = new Font(fontName, 10f, FontStyle.Regular);
            this.chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            this.chart1.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
            this.chart1.ChartAreas[0].AxisX.ToolTip = "实时时间";
            this.chart1.ChartAreas[0].AxisX.LineColor = ColorTranslator.FromHtml("#38587a");
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");


            //Y坐标轴 
            this.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font(fontName, 10f, FontStyle.Regular);          
            this.chart1.ChartAreas[0].AxisY.LineColor = ColorTranslator.FromHtml("#38587a");
            this.chart1.ChartAreas[0].AxisY.Title = "温度（℃）";
            this.chart1.ChartAreas[0].AxisY.TitleFont = new Font(fontName, 10f, FontStyle.Regular);
            this.chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            this.chart1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
            this.chart1.ChartAreas[0].AxisY.ToolTip = "温度（℃）";
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum =100;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            this.chart1.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            this.chart1.Series[0].Label = "#VAL";                //设置显示X Y的值    
            this.chart1.Series[0].LabelForeColor = Color.White;
            this.chart1.Series[0].ToolTip = "#VAL" + "℃";     //鼠标移动到对应点显示数值
            this.chart1.Series[0].ChartType = SeriesChartType.Column;    //图类型(折线)

            Legend legend = new Legend("legend");
            legend.Title = "legendTitle";
            this.chart1.Series[0].Color = Color.Lime;
            this.chart1.Series[0].LegendText = legend.Name;
            this.chart1.Series[0].IsValueShownAsLabel = true;
            this.chart1.Series[0].LabelForeColor = Color.White;
            this.chart1.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            this.chart1.Legends.Add(legend);
            this.chart1.Legends[0].Position.Auto = false;

 
            //绑定数据
            //this.chart1.Series[0].Points.DataBindXY(x, y);
            //this.chart1.Series[0].Points[0].Color = Color.White;
            //this.chart1.Series[0].Palette = ChartColorPalette.Bright;

            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
            if (rb1.Checked)
            {
                this.chart1.Titles[0].Text =string.Format( "设备温度显示（{0}）",rb1.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.FastPoint;
            }
            if (rb2.Checked) {
                this.chart1.Titles[0].Text = string.Format("设备温度显示（{0}）", rb2.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            }
            this.chart1.Series[0].Points.Clear();
        }
        
        //更新队列中的值
        private void UpdateQueueValue() {
            

            if (dataQueue.Count > 20) {
                //先出列
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Dequeue();
                    xData.Dequeue();
                }
            }
            if (rb1.Checked)
            {
                Random r = new Random();
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Enqueue(r.Next(0, 100));
                    xData.Enqueue(DateTime.Now.ToString("hh:mm:ss"));
                }
            }
            if (rb2.Checked) {
                for (int i = 0; i < num; i++)
                {
                    //对curValue只取[0,360]之间的值
                    curValue = curValue % 360;
                    //对得到的正玄值，放大50倍，并上移50
                    dataQueue.Enqueue((50*Math.Sin(curValue*Math.PI / 180))+50);
                    curValue=curValue+10;
                }
            }
        }
    }
}
