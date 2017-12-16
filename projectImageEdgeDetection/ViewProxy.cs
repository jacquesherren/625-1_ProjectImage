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
            //ImageController imageController = new ImageController(this);
            return ImageController.Laplacian3x3(source);
        }

        public MyImage LoadImage()
        {
            //ImageController imageController = new ImageController(this);
            return ImageController.LoadImage();
        }

        public MyImage SetColorFilter(MyImage source, int max, int min, Color color)
        {
            //ImageController imageController = new ImageController(this);
            return ImageController.SetColorFilter(source,max,min,color);
        }

    }
}
