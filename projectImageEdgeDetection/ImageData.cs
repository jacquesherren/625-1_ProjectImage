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
        private IData data = new DataProxy();


        public MyImage LoadImageFromDisk()
        {
            
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                Bitmap map = new Bitmap(op.FileName);
                MyImage image = new MyImage(map, false);

                return image;
            }
            return null;
        }

    }
}
