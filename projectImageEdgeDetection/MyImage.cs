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
        private Bitmap Bitmap { get; set; }
        private Boolean Filtred { get; set; }

        public MyImage(Bitmap bitmap, Boolean filtred)
        {
            this.Bitmap = bitmap;
            this.Filtred = filtred;
            
        }

        public Bitmap GetBitmap()
        {
            return this.Bitmap;
        }
        public void SetBitmap(Bitmap bitmap)
        {
            this.Bitmap = bitmap;
        }

        public Boolean IsFiltred()
        {
            return this.Filtred;
        }
        public void SetFiltred(Boolean filtred)
        {
            this.Filtred = filtred;
        }
    }
}
