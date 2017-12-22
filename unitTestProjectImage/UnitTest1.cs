﻿using System;
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

            MyImage expected = CreateMyImage("source");
            ImageComp.LoadImageFromDisk().Returns(expected);

            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.LoadImage();


            ParsingImage(expected, target);

        }

        [TestMethod]
        public void TestLaplacian3x3()
        {
            var ImageComp = Substitute.For<IView>();

            MyImage expected = CreateMyImage("url\\Ressource\\expecteLAP.png");
            MyImage source = CreateMyImage("source");
            ImageComp.Laplacian3x3Filter(source).Returns(expected);

            ImageCtrl ic = new ImageCtrl(ImageComp);
            MyImage target = ic.Laplacian3x3(source);


            ParsingImage(expected, target);
        }



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
