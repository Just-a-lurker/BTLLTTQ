using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLTTQ
{
    public struct RevenueByDate
    { 
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    class Dashboard 
    {
        Merdul functions=new Merdul();
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int NumCustomers { get; private set; }
        public int NumProducts { get; private set; }
        public int NumSuppliers { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public Dashboard()
        {

        }
        private void GetNumberItems()
        {
            NumCustomers = Convert.ToInt32( functions.GetFieldValues("Select count(MaKhach) from KhachHang"));
            NumSuppliers= Convert.ToInt32(functions.GetFieldValues("Select count(MaNCC) from NhaCungCap"));
            NumProducts= Convert.ToInt32(functions.GetFieldValues("Select count(MaNoiThat) from DMNoiThat"));
            NumOrders = Convert.ToInt32(functions.GetFieldValues("Select count(SoDDH) from DonDatHang "));
                //where NgayDat between "+Convert.ToDateTime(startDate) +" and "+ Convert.ToDateTime(endDate) + ""));

        }
        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue= 0;

            using (var connection = functions.GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection=connection;
                    command.CommandText = @"Select NgayDat,sum(TongTien) from DonDatHang where NgayDat between @fromDate and @toDate group by NgayDat";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader=command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0],(decimal)reader[1]));
                        TotalRevenue += (decimal)                                                       reader[0];
                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    reader.Close();
                    if(numberDays<=30)
                    {
                        foreach(var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {

                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value

                            }) ;
                        }
                    }
                    
                    else if(numberDays<=92)
                    {
                        GrossRevenueList=(from orderlist in resultTable
                                          group orderlist by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(orderlist.Key,CalendarWeekRule.FirstDay,DayOfWeek.Monday)
                           into order
                           select new RevenueByDate
                           {
                               Date="Week"+order.Key.ToString(),
                               TotalAmount=order.Sum(amount=> amount.Value)
                           }).ToList();
                    }
                    
                    
                    else if (numberDays <= (365)*2)
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderlist in resultTable
                                            group orderlist by orderlist.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear?order.Key.Substring(0,order.Key.IndexOf(" ")):order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                     else
                    {
                        GrossRevenueList = (from orderlist in resultTable
                                            group orderlist by orderlist.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }
   
    
        private void getProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection=functions.GetConnection())
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top(5) P.TenNoiThat,sum(ChiTietHDDH.SoLuong) as Q
                     from ChiTietHDDH
                     inner join DMNoiThat P On P.MaNoiThat=ChiTietHDDH.MaNoiThat
                     inner join DonDatHang O On O.SoDDH=ChiTietHDDH.SoDDH
                     where NgayDat between @fromDate and @toDate group by P.TenNoiThat order by Q desc";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                
                reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(),
                            (int)reader[1]));
                    }
                    reader.Close();
                    command.CommandText = @"Select TenNoiThat,SoLuong from DMNoiThat
                        where SoLuong<=5";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }

            }
        }
   
    
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year,endDate.Month,endDate.Day,endDate.Hour,endDate.Minute,59);
            if(startDate!=this.startDate||endDate!=this.endDate)
            {
                this.endDate = endDate;
                this.startDate = startDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                getProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine("Refreshed Data,:{0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed,same querry:{0} - {1}",startDate.ToString(),endDate.ToString());
                return false;   
            }
           
        }
    }
}
