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
        /*
         * TestLoadImageFromDisk:
         * To check the Load Image From Disk
         */
        [TestMethod]
        public void TestLoadImageFromDisk()
        {
            //Create a substitute for the Interface IData
            var ImageComp = Substitute.For<IData>();

            //Initiate the object
            MyImage expected = new MyImage(Properties.Resources.source,"expected");

            //Give instruction to return the image source
            ImageComp.LoadImageFromDisk().Returns(expected);

            // Run the method
            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.LoadImage();

            //check the return
            ParsingImage(expected, target);

        }
        /*
         * TestSaveImageToDisk:
         * To check the Save Image To Disk
         */
        [TestMethod]
        public void TestSaveImageToDisk()
        {
            //Create a substitute for the Interface IData
            var ImageComp = Substitute.For<IData>();

            //Initiate the object
            MyImage source = new MyImage(Properties.Resources.source,"source");
            MyImage expected = new MyImage(Properties.Resources.source, "expected");

            //Give instruction to return the image source
            ImageComp.SaveImageToDisk(source,"source").Returns<String>("C:\\temp\\SaveTest.png");

            // Run the method
            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.SaveImage();

            //check the return
            ParsingImage(expected, target);

        }
        /*
         * TestLaplacian3x3:
         * To check the Laplacian function
         */

        [TestMethod]
        public void TestLaplacian3x3()
        {
            //Create a substitute for the Interface IData
            var ImageComp = Substitute.For<IView>();

            //Initiate the object
            MyImage expected = new MyImage(Properties.Resources.Laplacian3x3,"laplacian");
            MyImage source = new MyImage(Properties.Resources.source,"source");

            // Give instruction to return the image expected
            ImageComp.Laplacian3x3Filter(source).Returns(expected);

            // Run the method
            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.Laplacian3x3(source);

            //Check the return
            ParsingImage(expected, target);
        }
        /*
         * TestSetColorFilter:
         * To check the SetColor function
         */
        [TestMethod]
        public void TestSetColorFilter()
        {
            //Create a substitute for the Interface IView
            var ImageComp = Substitute.For<IView>();
            //Initiate the object
            MyImage expected = new MyImage(Properties.Resources.GreenFilter, "greenFilter");
            MyImage source = new MyImage(Properties.Resources.source, "source");

            // Give instruction to return the image expected
            ImageComp.SetColorFilter(source).Returns(expected);

            // Run the method
            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.SetColorFilter(source);

            // Run the method
            ParsingImage(expected, target);
        }

        /*
        //Pas utile si on utilise les properties.Resources
        private static MyImage CreateMyImage(String url)
        {
            Bitmap bmp = new Bitmap(GetImage(url));
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
        */


        /*
         * ParsingImage:
         * To check 2 Images
         */
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
