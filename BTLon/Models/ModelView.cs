using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
