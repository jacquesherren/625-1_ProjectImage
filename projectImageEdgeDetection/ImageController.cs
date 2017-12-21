using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectImageEdgeDetection
{
   public static class ImageController
    {
        public static MyImage LoadImage()
        {
            IData iData = new DataProxy();
            MyImage img = new MyImage(iData.LoadImageFromDisk(), false);
            return img;
        }

        public static MyImage Laplacian3x3(MyImage source)
        {

            MyImage res = new MyImage(source.GetBitmap(), false);

            res.SetBitmap(ConvolutionFilter(source.GetBitmap(), MatrixLaplacian3x3, 1.0, 0, false));
            res.SetFiltred(true);

            return res;
        }

        public static Boolean SaveImage(MyImage myImage, String name)
        {
            IData idata = new DataProxy();
            return idata.SaveImageToDisk(myImage.GetBitmap(), name);
        }

        public static MyImage SetColorFilter(MyImage source,int max,int min,Color color)
        {

            MyImage res = new MyImage(source.GetBitmap(), false);

            res.SetBitmap(SetColorFilter(res.GetBitmap(), max, min, color));
            res.SetFiltred(true);

            return res;
        }

        private static Bitmap SetColorFilter(this Bitmap bmp, int max, int min, Color color)
        {
            // create temp bitmap
            Bitmap resultBitmap = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++) // browse image row
            {
                for (int j = 0; j < bmp.Height; j++) // browse image  column
                {
                    Color colorPixel = bmp.GetPixel(i, j); // recover each color pixel
                    if (colorPixel.G > min && colorPixel.G < max)
                    { // if not green (between the green gap) change to white else green
                        Color cLayer = Color.White; // set to white
                        resultBitmap.SetPixel(i, j, cLayer); // change pixel to white
                    }
                    else
                    {
                        resultBitmap.SetPixel(i, j, color); //  change to green
                    }
                }
            }
            return resultBitmap; // return result
        }


        public static double[,] MatrixLaplacian3x3
        {
            get
            {
                return new double[,]
                { { -1, -1, -1,  },
                  { -1,  8, -1,  },
                  { -1, -1, -1,  }, };
            }
        }

        private static Bitmap ConvolutionFilter(Bitmap bitmapSource,
                                        double[,] filterMatrix,
                                             double factor = 1,
                                                  int bias = 0,
                                        bool grayscale = false)
        {
            BitmapData sourceData = bitmapSource.LockBits(new Rectangle(0, 0,
                                     bitmapSource.Width, bitmapSource.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            bitmapSource.UnlockBits(sourceData);

            if (grayscale == true)
            {
                float rgb = 0;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                bitmapSource.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    bitmapSource.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(bitmapSource.Width, bitmapSource.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                 PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }



    }

   

}
