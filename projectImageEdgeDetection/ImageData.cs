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
        private Bitmap map;


        public Bitmap LoadImageFromDisk()
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = op.FileName;
                map = new Bitmap(op.FileName);

                return map;
            }
            return null;
        }

    }
}
