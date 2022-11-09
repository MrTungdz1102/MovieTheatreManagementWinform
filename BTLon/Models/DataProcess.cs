using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BTLon.Models
{
    internal class DataProcess
    {
        string strConnect = "Data Source=DESKTOP-F087CPF\\SQLEXPRESS;" + "DataBase=QuanLyRapChieuPhim;User ID=longnt;"
            + "Password=Anhlong123; Integrated Security=false";
        SqlConnection sqlConnect = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
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
    }
}
