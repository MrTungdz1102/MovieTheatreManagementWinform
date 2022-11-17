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
        int numberFoodAll;
        Decimal FoodSum;
        Decimal SumAll;
        public List<DetailTicket> SoGheDaChon { get; set; }
        public List<DetailFoodSelected> foodSelecteds { get; set; }
        public UserBookTick()
        {
            InitializeComponent();
            process = new DataProcess();
            SoGheDaChon = new List<DetailTicket>();
            foodSelecteds = new List<DetailFoodSelected>();
            SumTienGhe = 0;
            numberFoodAll = 0;
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
        public string GetTongTienVe()
        {
            return lblSum.Text;
        }
        public string GetTenPhim()
        {
            return lblTenPhim.Text;
        }
        //Tính vé
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
            UserBill bill = new UserBill(this);
            Models.ModelView.addUserToPanel(panelKH, null, bill, DockStyle.Fill);
            //if (SoGheDaChon.Count > 0)
            //{
            //    ModelView.InsertData("V", "KH001", "NV01", lblPC.Tag.ToString(), SoGheDaChon);
            //    if (foodSelecteds.Count > 0)
            //    {
            //        Decimal TongTien = Decimal.Parse(lblPriceCB.Text);
            //        Models.ModelView.InsertData2("HD", "NV01", "KH001", TongTien, foodSelecteds);
            //        MessageBox.Show("Thêm thành công!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Chưa chọn ghế!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //foreach (DetailFoodSelected selected in foodSelecteds)
            //{
            //    MessageBox.Show(selected.codeFood + "," + selected.NameFood + "," + selected.Price.ToString() + "," + selected.size);
            //}
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
            numberFoodAll = 0;
            FoodSum = 0;
        }
        private void setSumFood(Decimal PriceFood) //Tính tiền khi cộng giá lên hoặc giảm giá đi
        {
            SumAll += PriceFood;
            FoodSum += PriceFood;
            lblPriceCB.Text = Math.Round(SumAll, 0).ToString();
            txtNumberFood.Text = numberFoodAll.ToString();
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
                        numberFoodAll = selected.size;
                        FoodSum = selected.Price;
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
            numberFoodAll++;
            Decimal PriceFood = Decimal.Parse(txtPrice.Text); //Lấy giá của từng sản phẩm
            setSumFood(PriceFood);
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foodSelecteds.Clear();
            cbFoodSelected.DataSource = null;
            txtNumberFood.Text = "0";
            txtNumberSelected.Text = "";
            lblPriceCB.Text = "";
            numberFoodAll = 0;
            SumAll = 0;
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Decimal PriceFood = Decimal.Parse(txtPrice.Text);
            Decimal FirstFoodSum = FoodSum; //Lấy giá trị ban đầu khi chưa trừ
            DetailFoodSelected foodSelected;
            //Kiểm tra điều kiện khi trừ
            if (numberFoodAll > 0 && FoodSum > 0 && Decimal.Parse(lblPriceCB.Text) >= (Decimal.Parse(lblPriceCB.Text) - FirstFoodSum))
            {
                numberFoodAll--;
                foreach (DetailFoodSelected selected in foodSelecteds)
                {
                    if (selected.NameFood == cbFood.Text)
                    {
                        selected.Price = FoodSum;
                        selected.size = numberFoodAll;
                        foodSelected = selected;
                        if (numberFoodAll == 0)
                        {
                            foodSelecteds.Remove(selected);
                            txtNumberSelected.Text = "";
                        }
                        AddFoodSelectedToCombo();
                        break;
                    }
                }
                setSumFood(-PriceFood);
            }
            else
            {
                return;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtNumberFood.Text == "0")
            {
                MessageBox.Show("Nhập số lượng");
            }
            else
            {
                int number = int.Parse(txtNumberFood.Text);
                foreach (DetailFoodSelected selected in foodSelecteds)
                {
                    if (selected.NameFood == cbFood.Text)
                    {
                        if (selected.size == int.Parse(txtNumberFood.Text))
                        {
                            return;
                        }
                        else
                        {
                            selected.size = number;
                            AddFoodSelectedToCombo();
                            return;
                        }
                    }
                }
                DetailFoodSelected foodSelected = new DetailFoodSelected()
                {
                    NameFood = cbFood.Text,
                    Price = SumAll,
                    size = number,
                    codeFood = cbFood.Tag.ToString()
                };
                foodSelecteds.Add(foodSelected);
                AddFoodSelectedToCombo();
                lblPriceCB.Text = SumAll.ToString();
            }
        }
        private void GetControls()
        {
            foreach (Control control in panelListButton.Controls)
            {
                Button button = (Button)control;
                button.BackColor = Color.Aqua;
            }
        }
    }
}
