using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
    public class DataProxy : IData
    {
        private ImageData imageData;

        public MyImage LoadImageFromDisk()
        {
            imageData = new ImageData();
            return imageData.LoadImageFromDisk();
        }

        public  Boolean SaveImageToDisk(MyImage myImage, String name)
        {
            imageData = new ImageData();
            return imageData.SaveImageToDisk(myImage, name);
        }

        
    }
}
