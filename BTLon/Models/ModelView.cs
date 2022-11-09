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
    internal class ModelView
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
        public static void addListPicture(Panel panelPicture, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Panel pan = new Panel();
                pan = GetPanel(168, 274, Color.Red);
                PictureBox picture = new PictureBox();
                object oj = table.Rows[i][0];
                byte[] img = oj as byte[];
                Image image = ModelView.ByteArrayToImage(img);
                picture = GetPictureBox(168, 244, DockStyle.Top, PictureBoxSizeMode.StretchImage, image);
                Button button = new Button();
                button = GetButton(DockStyle.Bottom, FlatStyle.Flat, 0, Color.Red);
                pan.Controls.Add(picture);
                pan.Controls.Add(button);
                panelPicture.Controls.Add(pan);
            }
        }
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
        public static Panel GetPanel(int with, int height, Color color)
        {
            Panel pan = new Panel();
            pan.BackColor = color;
            pan.Width = with;
            pan.Height = height;
            return pan;
        }
        public static Button GetButton(DockStyle style, FlatStyle flat, int BorderSize, Color color)
        {
            Button button = new Button();
            button.Dock = style;
            button.FlatStyle = flat;
            button.FlatAppearance.BorderSize = BorderSize;
            button.BackColor = color;
            return button;
        }
    }
}
