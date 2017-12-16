using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    class ViewProxy : IView
    {
        public MyImage Laplacian3x3Filter(MyImage source)
        {
            return ImageController.Laplacian3x3(source);
        }

        public MyImage LoadImage()
        {
   
            return ImageController.LoadImage();
        }

        public MyImage SetColorFilter(MyImage source, int max, int min, Color color)
        {
            return ImageController.SetColorFilter(source,max,min,color);
        }

    }
}
