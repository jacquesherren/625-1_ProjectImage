using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using projectImageEdgeDetection;
using System.IO;
using System.Drawing;

namespace unitTestProjectImage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoadImageFromDisk()
        {

            var ImageComp = Substitute.For<IData>();

            MyImage expected = CreateMyImage();
            ImageComp.LoadImageFromDisk().Returns(expected);

            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.LoadImage();


            ParsingImage(expected, target);

        }



        private static MyImage CreateMyImage()
        {
            Bitmap bmp = new Bitmap(GetImage("C:\\Users\\Jacques\\Source\\Repos\\625-1_ProjectImage\\projectImageEdgeDetection\\Resources\\source.png"));
            MyImage image = new MyImage(bmp, "test");

            return image;
        }

        private static Bitmap GetImage(string url)
        {
            StreamReader streamReader = new StreamReader(url);
            Bitmap imageBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return imageBitmap;
        }

        public void ParsingImage(MyImage expected, MyImage result)
        {
            Bitmap bmpExpected = expected.Bitmap;
            Bitmap bmpResult = result.Bitmap;

            for (int i = 0; i < bmpResult.Width; i++)
            {
                for (int j = 0; j < bmpResult.Height; j++)
                {
                    Color colorPixelResult = bmpResult.GetPixel(i, j);
                    Color colorPixelExpected = bmpExpected.GetPixel(i, j);
                    Assert.AreEqual(colorPixelResult, colorPixelExpected);
                }
            }
        }
    }
}
