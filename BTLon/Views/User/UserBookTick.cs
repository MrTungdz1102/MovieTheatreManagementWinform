using BTLon.Controls;
using BTLon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserBookTick : UserControl
    {
        DataProcess process;
        decimal SumTienGhe;
        int numberFoodCount;
        Decimal FoodSum;
        Decimal SumAll;
        public List<DetailTicket> SoGheDaChon { get; set; }
        public List<DetailFoodSelected> foodSelecteds { get; set; }

        public string MaLC;
        public UserBookTick()
        {
            InitializeComponent();
            process = new DataProcess();
            SoGheDaChon = new List<DetailTicket>();
            foodSelecteds = new List<DetailFoodSelected>();
            SumTienGhe = 0;
            numberFoodCount = 0;
            SumAll = 0;
        }
        private void UserBookTick_Load(object sender, EventArgs e)
        {
            lblTenRap.Text = " CGV vincom \r\n Center Bà Triệu";
            AddFoodToCombo();
        }
        public void SetLabelPC(string text, string tag)
        {
            this.lblPC.Text = text;
            this.lblPC.Tag = tag;
        }
        public void SetLabelPhim(string text)
        {
            this.lblTenPhim.Text = text;
        }
        public void SetPictureBox(Image image)
        {
            this.ptbPhim.Image = image;
        }
        public void SetLabelTGC(string text)
        {
            this.lblThoiGianChieu.Text = text;
        }
        public void SetLabelNgayChieu(string text)
        {
            this.lblNgayChieu.Text = text;
        }
        public void SetConTrolsInPanelKH()
        {
            panelKH.Controls.Clear();
        }
        public string GetNC()
        {
            return lblNgayChieu.Text;
        }
        public string GetTGC()
        {
            return lblThoiGianChieu.Text;
        }
        public string GetPC()
        {
            return lblPC.Text;
        }
        public string GetTagPC()
        {
            return lblPC.Tag.ToString();
        }
        public string GetTongTienVe()
        {
            return lblSum.Text;
        }
        public string GetTenPhim()
        {
            return lblTenPhim.Text;
        }
        public string GetPriceFood()
        {
            return lblPriceCB.Text;
        }
        //Tính vé
        //Load những ghế đã có người đặt
        public void SetButton()
        {
            foreach (Control control in panelListButton.Controls)
            {
                Button button = (Button)control;
                button.Enabled = true;
                button.BackColor = Color.White;
            }
        }
        public void GetAndSetControls()
        {
            string sql = "select * from ThongTinGheTrong(N'" + MaLC + "')";
            DataTable data = process.DataReader(sql);
            if (data.Rows.Count > 0 ) 
            {
                string[] soPC = lblPC.Text.ToString().Split(' ');
                foreach (Control control in panelListButton.Controls)
                {
                    Button button = (Button)control;
                    string SoGhe = button.Tag.ToString() + soPC[2] + "-" + button.Text;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i][0].ToString() == SoGhe)
                        {
                            button.BackColor = Color.Gray;
                            button.Enabled = false;
                        }
                    }
                }
            }
            else 
            {
                return;
            }
        }
        //Hàm này để bắt sự kiện người dùng chọn ghế
        private void book_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string[] soPC = lblPC.Text.ToString().Split(' ');
            string SoGhe = button.Tag.ToString() + soPC[2] + "-" + button.Text;
            if (button.BackColor == Color.White)
            {
                DetailTicket detail = new DetailTicket();
                button.BackColor = Color.Brown;
                detail.MaGhe = SoGhe;
                detail.GiaTien = process.DataFunction(SoGhe, lblPC.Tag.ToString());
                SumTienGhe += process.DataFunction(SoGhe, lblPC.Tag.ToString());
                this.lblSum.Text = Math.Round(SumTienGhe, 0).ToString();
                SoGheDaChon.Add(detail);
            }
            else
            {
                button.BackColor = Color.White;
                SumTienGhe -= process.DataFunction(SoGhe, lblPC.Tag.ToString());
                if (SumTienGhe == 0)
                {
                    this.lblSum.Text = "";
                }
                else
                {
                    this.lblSum.Text = Math.Round(SumTienGhe, 0).ToString();
                }
                foreach (DetailTicket detail in SoGheDaChon)
                {
                    if (detail.MaGhe == SoGhe)
                    {
                        SoGheDaChon.Remove(detail);
                        break;
                    }
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (SoGheDaChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(numberFoodCount > 0 && cbFoodSelected.Text == "")
            {
                if(MessageBox.Show("Bạn có muốn tiếp tục?", "Có vẻ như bạn chưa thêm đồ ăn vừa chọn!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UserBill bill = new UserBill(this);
                    Models.ModelView.addUserToPanel(panelKH, null, bill, DockStyle.Fill);
                }
            }
            else
            {
                SumComBo();
                UserBill bill = new UserBill(this);
                Models.ModelView.addUserToPanel(panelKH, null, bill, DockStyle.Fill);
                foreach (DetailFoodSelected selected in foodSelecteds)
                {
                    MessageBox.Show(selected.codeFood + "," + selected.NameFood + "," + selected.Price.ToString() + "," + selected.size);
                }
            }
        }
        //Tính hóa đơn
        private void AddFoodToCombo()
        {
            string sql = "select TenSP, Gia, MaSP from tblDoAn_NuocUong";
            DataTable data = process.DataReader(sql);
            List<DetailFood> foodList = new List<DetailFood>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DetailFood food = new DetailFood()
                {
                    NameFood = data.Rows[i][0].ToString(),
                    Price = data.Rows[i][1].ToString(),
                    CodeFood = data.Rows[i][2].ToString()
                };
                foodList.Add(food);
            }
            cbFood.DataSource = foodList;
            cbFood.DisplayMember = "NameFood";
        }
        private void AddFoodSelectedToCombo()
        {
            cbFoodSelected.DataSource = null;
            cbFoodSelected.DataSource = foodSelecteds;
            cbFoodSelected.DisplayMember = "NameFood";
        }
        private void setFood()
        {
            txtNumberFood.Text = "0";
            numberFoodCount = 0;
            lblPriceAFood.Text = "0";
        }
        private void cbFood_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFood.SelectedValue != null)
            {
                setFood();
                DetailFood food = cbFood.SelectedValue as DetailFood;
                foreach (DetailFoodSelected selected in foodSelecteds)
                {
                    if (selected.NameFood == food.NameFood)
                    {
                        txtNumberFood.Text = selected.size.ToString();
                        numberFoodCount = selected.size;
                        lblPriceAFood.Text = selected.Price.ToString();
                        break;
                    }
                }
                cbFood.Tag = food.CodeFood;
                txtPrice.Text = Math.Round(Decimal.Parse(food.Price), 0).ToString();
            }
        }
        private void cbFoodSelected_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFoodSelected.SelectedValue != null)
            {
                DetailFoodSelected foodSelected = cbFoodSelected.SelectedValue as DetailFoodSelected;
                txtNumberSelected.Text = foodSelected.size.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            numberFoodCount++;
            Decimal PriceFood = Decimal.Parse(txtPrice.Text); //Lấy giá của từng sản phẩm
            lblPriceAFood.Text = Math.Round(PriceFood * numberFoodCount,2).ToString();
            txtNumberFood.Text = numberFoodCount.ToString();
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foodSelecteds.Clear();
            cbFoodSelected.DataSource = null;
            txtNumberFood.Text = "0";
            txtNumberSelected.Text = "";
            lblPriceCB.Text = "";
            numberFoodCount = 0;
            SumAll = 0;
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Decimal PriceFood = Decimal.Parse(txtPrice.Text);
            if(numberFoodCount > 0)
            {
                numberFoodCount--;
            }
            else
            {
                numberFoodCount = 0;
            }
            txtNumberFood.Text = numberFoodCount.ToString();
            lblPriceAFood.Text = Math.Round(PriceFood * numberFoodCount, 2).ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtNumberFood.Text == "0")
            {
                MessageBox.Show("Nhập số lượng");
            }
            else
            {
                Decimal PriceFood = Decimal.Parse(txtPrice.Text);
                foreach (DetailFoodSelected detailFoodSelected in foodSelecteds)
                {
                    if(detailFoodSelected.NameFood == cbFood.Text)
                    {
                        detailFoodSelected.Price = PriceFood * numberFoodCount;
                        detailFoodSelected.size = numberFoodCount;
                        AddFoodSelectedToCombo();
                        return;
                    }
                }
                DetailFoodSelected foodSelected = new DetailFoodSelected()
                {
                    NameFood = cbFood.Text,
                    Price = PriceFood * numberFoodCount,
                    size = numberFoodCount,
                    codeFood = cbFood.Tag.ToString()
                };
                foodSelecteds.Add(foodSelected);
                AddFoodSelectedToCombo();
            }
        }
        private void SumComBo()
        {
            Decimal sum = 0;
            foreach (DetailFoodSelected foodSelected in foodSelecteds)
            {
                sum += foodSelected.Price;
            }
            lblPriceCB.Text = Math.Round(sum, 2).ToString();
        }
        private void btnSumAll_Click(object sender, EventArgs e)
        {
            SumComBo();
        }
    }
}
