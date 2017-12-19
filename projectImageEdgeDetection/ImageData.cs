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
    
        public Bitmap LoadImageFromDisk()
        {
            
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                Bitmap map = new Bitmap(op.FileName);
                //MyImage image = new MyImage(map, false);

                return map;
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
