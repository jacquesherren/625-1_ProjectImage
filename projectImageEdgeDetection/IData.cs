using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
     public interface IData
    {
        MyImage LoadImageFromDisk();

        Boolean SaveImageToDisk();
    }
}
