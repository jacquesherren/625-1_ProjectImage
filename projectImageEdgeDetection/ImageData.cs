using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
    public class ImageData
    {
    
        public MyImage LoadImageFromDisk()
        {
            

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select an image file.";
            op.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            op.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = op.FileName;
                Bitmap map = new Bitmap(op.FileName);
                MyImage image = new MyImage(map, op.FileName);
                return image;
            }

            return null;
        }

        public Boolean SaveImageToDisk(Bitmap myImage, String name)
        {
            PictureBox picture = new PictureBox();
            picture.Image = myImage;
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            FolderBrowserDialog fl = new FolderBrowserDialog();
            if (fl.ShowDialog() != DialogResult.Cancel)
            {
                picture.Image.Save(fl.SelectedPath + @"\" + name + @".png", System.Drawing.Imaging.ImageFormat.Png);
                return true;
            };
            return false;
        }
        
    }
}
