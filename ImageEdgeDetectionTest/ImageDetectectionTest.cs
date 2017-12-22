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
            MyImage image = new MyImage();
            image.SetBitmap(new Bitmap(GetImage("../../Resources/source.png")));
           
            //Give instruction to return the image source
            ImageComp.LoadImageFromDisk().Returns(image);

            // Run the method
            Bitmap myBitmap = iData1.LoadImageFromDisk();
            
            //check the return
            ParsingImage(source, myBitmap);
        }

        [TestMethod]
        public void SaveImageToDiskTest()
        {
            //Create a Substitute for the Interface IData
            var ImageComp = Substitute.For<IData>();

            //Initiate the object
            ImageData iData2 = new ImageData();
            Bitmap test = new Bitmap(GetImage("../../Resources/source.png"));
            string pathTest = "../../Resources/source1.png";

            //Give instruction to save the image
            ImageComp.SaveImageToDisk(test, pathTest);

            //check and parse if the two images are the same
            ParsingImage(test, iData2.LoadImageFromDisk());

        }

        public Bitmap GetImage(string url)
        {
            StreamReader streamReader = new StreamReader(url);
            Bitmap imageBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return imageBitmap;
        }

        public void ParsingImage( Bitmap expectedBitmap, Bitmap resultBitmap)
        {
            //Parsing the 2 pictures to compare the pixels
            for (int i = 0; i < resultBitmap.Width; i++)
            {
                for (int j = 0; j < resultBitmap.Height; j++)
                {
                    Color colorPixelResult = resultBitmap.GetPixel(i, j);
                    Color colorPixelExpected = expectedBitmap.GetPixel(i, j);
                    Assert.AreEqual(colorPixelResult, colorPixelExpected);
                }
            }
            
        }
    }
}
