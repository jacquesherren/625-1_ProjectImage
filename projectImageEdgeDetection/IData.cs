using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
     public interface IData
    {
        ///Function to Load an Image
        MyImage LoadImageFromDisk();

        ///Function to Save a Image
        String SaveImageToDisk(MyImage myImage, String name);
    }
}
