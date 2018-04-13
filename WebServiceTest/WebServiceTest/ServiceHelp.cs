using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Data;
using System.Web.Script.Serialization;
using System.Collections;

namespace Common.Service
{
    public static class ServiceHelp
    {
        public static string GetServiceData(string serviceUri) 
        {
            try
            {
                WebClient wc = new WebClient();

                wc.Headers.Add("Content-Type", "application/json");
                wc.Encoding = Encoding.GetEncoding("UTF-8");

                byte[] responseData = wc.DownloadData(serviceUri);
                string strResponseData = Encoding.UTF8.GetString(responseData);

                return strResponseData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable ToDataTable(string jsonData)
        {
            try
            {
                DataTable result = new DataTable();

                if (!jsonData.StartsWith("["))
                {
                    jsonData = "[" + jsonData + "]";
                }

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; // 最大値の取得
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(jsonData);

                if (arrayList != null && arrayList.Count > 0)
                {
                    foreach (Dictionary<string, object> dictionary in arrayList)
                    {
                        if (dictionary.Keys.Count<string>() == 0)
                        {
                            break;
                        }

                        if (result.Columns.Count == 0)
                        {
                            foreach (string current in dictionary.Keys)
                            {
                                result.Columns.Add(current, dictionary[current] == null ? typeof(String) : dictionary[current].GetType());
                            }
                        }

                        DataRow dataRow = result.NewRow();
                        foreach (string current in dictionary.Keys)
                        {
                            dataRow[current] = dictionary[current];
                        }

                        // DataTableに添加
                        result.Rows.Add(dataRow); 
                    }
                }

                // DataTableの戻る
                return result;　
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
