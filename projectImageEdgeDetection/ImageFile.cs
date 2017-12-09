using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    class ImageFile
    {
        private Bitmap bitmap { get; set; }
        private double size { get; set; }

        public ImageFile (Bitmap bitmap, double size)
        {
            this.bitmap = bitmap;
            this.size = size;
        }

    }
}
