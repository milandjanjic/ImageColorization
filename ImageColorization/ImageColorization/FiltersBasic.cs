using System;
using System.Drawing;
using System.Drawing.Imaging;

public class BitmapFilterBasic
{

    public static bool GrayScale(Bitmap b) {

        for (int i = 0; i < b.Width; i++)
        {
            for (int x = 0; x < b.Height; x++)
            {
                Color oc = b.GetPixel(i, x);
                int grayScale = (int)((oc.R * 0.299) + (oc.G * 0.587) + (oc.B * 0.114));
                Color nc = System.Drawing.Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                b.SetPixel(i, x, nc);
            }
        }

        return true;
    }

    /*public static bool GrayScale(Bitmap b, double redR, double greenR, double blueR)
    {
        if (redR < -255 || redR > 255) return false;
        if (greenR < -255 || greenR > 255) return false;
        if (blueR < -255 || blueR > 255) return false;

        redR = (redR + 255.0) / 512.0;
        greenR = (greenR + 255.0) / 512.0;
        blueR = (blueR + 255.0) / 512.0;

        // GDI+ still lies to us - the return format is BGR, NOT RGB.
        BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);// PixelFormat.Format24bppRgb);

        int stride = bmData.Stride;
        System.IntPtr Scan0 = bmData.Scan0;

        unsafe
        {
            byte* p = (byte*)(void*)Scan0;

            int nOffset = stride - b.Width * 3;

            byte red, green, blue;

            for (int y = 0; y < b.Height; ++y)
            {
                for (int x = 0; x < b.Width; ++x)
                {
                    blue = p[0];
                    green = p[1];
                    red = p[2];

                    //p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);
                    p[0] = p[1] = p[2] = (byte)(redR * red + greenR * green + blueR * blue);

                    p += 3;
                }
                p += nOffset;
            }
        }

        b.UnlockBits(bmData);

        return true;
    }*/

    

}