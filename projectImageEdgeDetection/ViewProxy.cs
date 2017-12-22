using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    public class ViewProxy : IView
    {
        public MyImage Laplacian3x3Filter(MyImage source)
        {

            ImageCtrl ic = new ImageCtrl(this);
            return ic.Laplacian3x3(source);
        }

        public MyImage LoadImage()
        {
            ImageCtrl ic = new ImageCtrl();
            return ic.LoadImage();
        }

        public MyImage SetColorFilter(MyImage source, int max, int min, Color color)
        {
            ImageCtrl ic = new ImageCtrl(this);
            return ic.SetColorFilter(source,max,min,color);
        }

    }
}
