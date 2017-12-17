using NSubstitute;
using projectImageEdgeDetection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing;

namespace ImageEdgeDetectionTest
{
    [TestClass]
    public class ImageDetectectionTest
    {
        [TestMethod]
        public void LoadImageFromDiskTest()
        {
            //Create a substitute for the Interface IData
            var ImageComp = Substitute.For<IData>();

            //Initiate the object
            DataProxy dp = new DataProxy();

            MyImage source = new MyImage(GetImage("../../Resources/source.png"), false);

            //Give instruction to return the image source
            ImageComp.LoadImageFromDisk().Returns(source);
                        
            //run the method
            MyImage mImage = dp.LoadImageFromDisk();

            //check the return
            //Assert.AreEqual(source,MyImage);
        }

        public Bitmap GetImage(string url)
        {
            StreamReader streamReader = new StreamReader(url);
            Bitmap imageBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return imageBitmap;
        }
    }
}
