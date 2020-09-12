using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PhotographUtility
{
    public static class ImagePropertyUtility
    {
        public static ImageProperty[] GetImageProperties(Image image)
        {
            return image.PropertyItems.Select(p=>new ImageProperty(p)).ToArray();
        }
        public static ImageProperty[] GetImageProperties(string filename)
        {
            Image image = Image.FromFile(filename);
            return image.PropertyItems.Select(p => new ImageProperty(p)).ToArray();
        }
    }
}
