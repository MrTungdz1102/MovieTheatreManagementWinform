using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Runtime.Remoting.Contexts;
using BTLon.Views;

namespace BTLon.Models
{
    internal class DataProcess
    {
        string strConnect = "Data Source=MR_TUNG_PC\\TUNGDAO;Initial Catalog=QuanLyRapChieuPhim;Integrated Security=True";
        SqlConnection sqlConnect = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        public void OpenConnect()
        {
            try
            {
                sqlConnect = new SqlConnection(strConnect);
                if (sqlConnect.State != ConnectionState.Open)
                {
                    sqlConnect.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Error", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Error);
            }
        }
        public void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
            }
        }
        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }
        public DataSet DataSetReader(string sqlSelect, string nameTable)
        {
            OpenConnect();
            da = new SqlDataAdapter(sqlSelect, sqlConnect);
            ds = new DataSet();
            da.Fill(ds, nameTable);
            CloseConnect();
            return ds;
        }
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }
        public void DataSetChange(string nameTable)
        {
            OpenConnect();
            cmd = new SqlCommandBuilder(da);
            da.Update(ds, nameTable);
            CloseConnect();
        }
        public decimal DataFunction(string value1, string value2)
        {
            OpenConnect();
            string query = @"SELECT dbo.TienVe(@MaGhe,@MaLC)";
            SqlCommand cmd = new SqlCommand(query, sqlConnect);
            cmd.Parameters.Add("@MaGhe", value1);
            cmd.Parameters.Add("@MaLC", value2);
            decimal functionResult = (decimal)cmd.ExecuteScalar();
            return functionResult;
        }
        public void InsertImage(string MaNV, Image image)
        {
            byte[] img = ModelView.ImageToByteArray(image);
            OpenConnect();
            string sql = "update tblNhanVien set Anh = @img where MaNV = N'" + MaNV + "'";
            SqlCommand sqlcomma = new SqlCommand(sql, sqlConnect);
            sqlcomma.Parameters.Add("@img", img);
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }
        public void UseProc(string MaVe, string MaLC, string MaGhe, string MaKH, string MaNV, decimal GiaVe)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertData";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnect;
            //khai báo các thông tin của tham số truyền vào
            cmd.Parameters.Add("@MaVe", SqlDbType.NVarChar).Value = MaVe ;
            cmd.Parameters.Add("@MaLC", SqlDbType.NVarChar).Value = MaLC;
            cmd.Parameters.Add("@MaGhe", SqlDbType.NVarChar).Value = MaGhe;
            cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("@GiaVe", SqlDbType.Decimal).Value = GiaVe;
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public DataTable ReadDataSQL(string sqlSelect)
        {

            DataTable dt = new DataTable();
            OpenConnect();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConnect);
            sqlCmd.Parameters.AddWithValue("@user", Login.tk);
            sqlCmd.Parameters.AddWithValue("@pass", Login.mk);
        //    sqlCmd.Parameters.AddWithValue("@role", Login.role);
            //     sqlCmd.Connection = sqlCon;
            //    sqlCmd.CommandText = sqlSelect;
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
            sqlData.Fill(dt);
            CloseConnect();
            sqlData.Dispose();
            return dt;
        }
    }
}
