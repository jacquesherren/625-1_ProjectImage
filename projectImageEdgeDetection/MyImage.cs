using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectImageEdgeDetection
{
    public class MyImage
    {
        private Bitmap _Bitmap;
        private String _Name;
        private double _Size;

        public Bitmap Bitmap { get => _Bitmap; set => _Bitmap = value; }
        public string Name { get => _Name; set => _Name = value; }
        public double Size { get => _Size; set => _Size = value; }

        public MyImage()
        {

        }

        public MyImage(Bitmap bitmap, String name)
        {
            this._Bitmap = bitmap;
            this._Name = name;
            
        }

    }
}
