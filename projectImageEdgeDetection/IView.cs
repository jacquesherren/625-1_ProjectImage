﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    public interface IView
    {
        Bitmap Laplacian3x3Filter(Bitmap source);
        Bitmap otherMethodFilter(Bitmap source);


    }
}