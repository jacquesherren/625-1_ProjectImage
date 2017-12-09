using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    public class DataProxy : IData
    {
        private ImageData imageData;
        public Bitmap LoadImageFromDisk()
        {
            imageData = new ImageData();
            return imageData.LoadImageFromDisk();
        }

        public bool SaveImageToDisk()
        {
            throw new NotImplementedException();
        }
    }
}
