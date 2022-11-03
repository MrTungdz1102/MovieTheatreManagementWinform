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
    }
}
