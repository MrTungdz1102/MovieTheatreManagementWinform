using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace BTLon.Models
{
    internal class ModelView : EventArgs
    {
        public static Image Images(string name)
        {
            Image image = Image.FromFile(Path.GetFullPath("Picture\\" + name));
            return image;
        }
        public static byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        public static Image ByteArrayToImage(byte[] byteimg)
        {
            MemoryStream ms = new MemoryStream(byteimg);
            return Image.FromStream(ms);
        }
        //public static void addListPicture(Panel panelPicture, DataTable table, Button button)
        //{
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        Panel pan = new Panel();
        //        pan = GetPanel(168, 274, Color.Red);
        //        PictureBox picture = new PictureBox();
        //        object oj = table.Rows[i][0];
        //        byte[] img = oj as byte[];
        //        Image image = ModelView.ByteArrayToImage(img);
        //        picture = GetPictureBox(168, 244, DockStyle.Top, PictureBoxSizeMode.StretchImage, image);
        //        button = GetButton(DockStyle.Bottom, FlatStyle.Flat, 0, Color.Red);
        //        pan.Controls.Add(picture);
        //        pan.Controls.Add(button);
        //        panelPicture.Controls.Add(pan);
        //    }
        //}
        public static PictureBox GetPictureBox(int with,int height, DockStyle style, PictureBoxSizeMode sizeMode,Image image)
        {
            PictureBox picture = new PictureBox();
            picture.Dock = style;
            picture.SizeMode = sizeMode;
            picture.Width = with;
            picture.Height = height;
            picture.Image = image;
            return picture;
        }
        public static Panel GetPanel(int with, int height, Color color, DockStyle style, int Marginleft, BorderStyle border)
        {
            Panel pan = new Panel();
            pan.BackColor = color;
            pan.Width = with;
            pan.Height = height;
            pan.Dock = style;
            pan.Margin = new Padding(Marginleft, 3, 3, 3);
            pan.BorderStyle = border;
            return pan;
        }
        public static Guna2GradientButton GetButton(DockStyle style, int BorderRadius, Color color)
        {
            Guna2GradientButton button = new Guna2GradientButton();
            button.Dock = style;
            button.FillColor = color;
            button.FillColor2 = color;
            button.BorderRadius = BorderRadius;
            button.Text = "Đặt vé";;
            button.TextFormatNoPrefix = true;
            return button;
        }
        //public static void collapseMenu(Panel panel,bool check)
        //{
        //    if (check == true)
        //    {
        //        if (panel.Width > 100)
        //        {
        //            setMenu(true);
        //        }
        //        else
        //        {
        //            setMenu(false);
        //        }
        //    }
        //    else
        //    {
        //        if (panelMenu.Width == panelMenu.MinimumSize.Width)
        //        {
        //            setMenu(false);
        //        }
        //    }
        //}
        public static void collapseChild(Panel panel, bool check, int height)
        {
            if (check == true)
            {
                if (panel.Visible == false)
                {
                    panel.Visible = true;
                    panel.Height = height;
                }
                else
                {
                    panel.Visible = false;
                }
            }
            else
            {
                panel.Visible = false;
            }
        }
    }
}
