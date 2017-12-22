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
        MyImage LoadImageFromDisk();

        String SaveImageToDisk(MyImage myImage, String name);
    }
}
