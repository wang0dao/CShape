using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Service;

namespace WebServiceTest
{
    public partial class Form1 : Form
    {
        private const string mServiceUri = @"http://10.191.19.2:8080/eam/";

        public Form1()
        {
            InitializeComponent();
        }

        private DataTable GetStockShipDailyFileList()
        {
            try
            {
                string methodName = "getJSONObject";
                //string paraDatas = "procDate=" + dtpproc_date.Value.ToString("yyyyMMdd")
                //                 + "&warehouseCd=" + txtwarehouse_cd.Text
                //                 + "&productCd=" + txtprouct_cd.Text;

                string responseData = ServiceHelp.GetServiceData(@"http://10.191.19.2:8086/xl06-mes-web/services/update/requeststatus");

                return ServiceHelp.ToDataTable(responseData);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStockShipDailyFileList();
        }
    }
}
