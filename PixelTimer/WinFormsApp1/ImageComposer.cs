using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class ImageComposer
    {
        private Image parent = Properties.Resources.TownPixel;
        private Image toFuse = Properties.Resources.Night;


        public ImageComposer() 
        {
        }

        public Image GetFusionAt(double transparencyUnitarian) 
        {
            Bitmap combinedImage = new Bitmap(parent.Height, parent.Width);
            Graphics g = Graphics.FromImage(combinedImage);
            g.DrawImage(parent, new Point(0, 0));
            ColorMatrix cm = new ColorMatrix();
            cm.Matrix33 = (float)transparencyUnitarian;
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            g.DrawImage(toFuse, new Rectangle(0, 0, parent.Width, parent.Height),
            0, 0, toFuse.Width, toFuse.Height, GraphicsUnit.Pixel, ia);
            combinedImage.Save("test.png", ImageFormat.Png);
            return combinedImage;
        }
    }
}
