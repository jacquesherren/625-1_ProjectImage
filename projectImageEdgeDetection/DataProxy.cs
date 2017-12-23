using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
    public class DataProxy : IData
    {
        private ImageData imageData;

        public MyImage LoadImageFromDisk()
        {
            try
            {
                imageData = new ImageData();
                return imageData.LoadImageFromDisk();
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public String SaveImageToDisk(MyImage myImage, String name)
        {
            try
            {
                imageData = new ImageData();
                return imageData.SaveImageToDisk(myImage, name);
            }
            catch (Exception e)
            {
                return "";
            }
            
        }
                
    }
}
