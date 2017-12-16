using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
    public interface IView
    {
        MyImage Laplacian3x3Filter(MyImage source);
        MyImage SetColorFilter(MyImage source,int max,int min, Color color);
        MyImage LoadImage();
        Boolean SaveImage(MyImage myImage, String name);
    }
}
