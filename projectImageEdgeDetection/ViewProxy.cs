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
        public Bitmap Laplacian3x3Filter(Bitmap source)
        {
            ImageController imageController = new ImageController(this);
            return imageController.Laplacian3x3(source);
        }

        public Bitmap LoadImage()
        {
            ImageController imageController = new ImageController(this);
            return imageController.LoadImage();
        }

        public Bitmap otherMethodFilter(Bitmap source)
        {
            throw new NotImplementedException();
        }
    }
}
