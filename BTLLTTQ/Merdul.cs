using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace BTLLTTQ
{
    public class Merdul
    {
        //string strcon = @"Data Source=LAPTOP-PP0U79P7\SQLEXPRESS;Initial Catalog=Lttqnhom6;Integrated Security=True";
        string strcon = @"data source=" + DBNAME.NAME + @"\sqlexpress;initial catalog=Lttqnhom6;integrated security=true";
        SqlConnection con;
        //Lấy dữ liệu vào bảng
        public  void Connect()
        {
            con = new SqlConnection(strcon);
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public  void ConnectClose()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
            con.Dispose();
        }
        public void UpdateData(string sql)
        {
            Connect();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            cm.Dispose();
        }
        public  DataTable GetDataToTable(string sql)
        {
            DataTable tb = new DataTable();
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(tb);
            ConnectClose();
            return tb;
        }
        public bool CheckKey(string sql)
        {
            Connect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
            {
                ConnectClose();return true;
            }else
            {
                ConnectClose();
                return false;
            }
               
                
            
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strcon);
        }
        public string GetFieldValues(string sql)
        {
            Connect();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            ConnectClose();
            return ma;
        }
        public string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        public int Check_Account(string querry, string user, string pass, string euser, string epass)
        {
            Connect();
            SqlCommand sqlcommand = new SqlCommand(querry, con);
            sqlcommand.Parameters.AddWithValue(user, euser);
            sqlcommand.Parameters.AddWithValue(pass, epass);
            return (int)sqlcommand.ExecuteScalar();
            ConnectClose();
        }
        public void FillComboBox(string sql, System.Windows.Forms.ComboBox cb)
        {
            Connect();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = con;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            SqlDataReader DR = sqlcommand.ExecuteReader();
            while (DR.Read())
            {
                cb.Items.Add(DR[0]);

            }
            DR.Close();
            ConnectClose();
        }
        public string ChuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp break; 
                    switch ((mLen - i) % 9)
                    {
                        case 0:
                            mTemp = mTemp + " tỷ";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 6:
                            mTemp = mTemp + " triệu";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 3:
                            mTemp = mTemp + " nghìn";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        default:
                            switch ((mLen - i) % 3)
                            {
                                case 2:
                                    mTemp = mTemp + " trăm";
                                    break;
                                case 1:
                                    mTemp = mTemp + " mươi";
                                    break;
                            }
                            break;
                    }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", ""); //Loại bỏ trường hợp 00x 
            mTemp = mTemp.Replace("không mươi ", "linh "); //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename,string title)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = title;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                oDoc.SaveAs2(filename);
            }
        }

        public void RunSqlDel(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
            ConnectClose();
        }
    }
}
