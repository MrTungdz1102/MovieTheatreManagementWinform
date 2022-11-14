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
        public string DataFunction(string NameFunc,string value1, string value2)
        {
            OpenConnect();
            string Money;
            SqlCommand cmd = new SqlCommand(NameFunc,sqlConnect);

            // Kiểu của Command là StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số @p_Emp_Id và gán giá trị 100 cho nó.
            cmd.Parameters.Add("@MaGhe", SqlDbType.NVarChar).Value = value1;
            cmd.Parameters.Add("@MaLC", SqlDbType.NVarChar).Value = value2;
            // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
            SqlParameter resultParam = new SqlParameter("@TongTien", SqlDbType.Money);

            //  
            resultParam.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(resultParam);

            // Gọi hàm.
            cmd.ExecuteNonQuery();
            if (resultParam.Value != DBNull.Value)
            {
                Money = (string)resultParam.Value;
                return Money;
            }
            CloseConnect();
            return "0";
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
