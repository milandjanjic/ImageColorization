using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace CSharpFilters
{
	
	public struct FloatPoint
	{
		public double X;
		public double Y;
	}

	public class BitmapFilterConvolution
	{

		public static Bitmap GrayscaleToColor(Bitmap b)
		{

			IList<byte> grayscale = new List<byte>();

			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);

			int stride = bmData.Stride;
			System.IntPtr Scan0 = bmData.Scan0;

			unsafe
			{
				byte* p = (byte*)(void*)Scan0;

				int nOffset = stride - b.Width * 3;

				for (int y = 0; y < b.Height; ++y)
				{
					for (int x = 0; x < b.Width; ++x)
					{
						int pom = 0;

						if (p[0] >= 0 && p[0] < 11) //1  3.1
						{
							pom = p[0];
							p[2] = (byte)(0 + pom);
							p[1] = (byte)(0 + pom);
							p[0] = (byte)(0 + pom);
						}
						else if (p[0] >= 11 && p[0] < 23) //2  2.1
						{
							pom = p[0] - 11 -5;
							p[2] = (byte)(5 +pom);
							p[1] = (byte)(17 +pom);
							p[0] = (byte)(85 +pom);
						}
						else if (p[0] >= 23 && p[0] < 30) //3  1.8
						{
							pom = p[0] - 23 -1;
							p[2] = (byte)(71 + pom);
							p[1] = (byte)(1 + pom);
							p[0] = (byte)(31 + pom);
						}
						else if (p[0] >= 30 && p[0] < 44) //4  2.8
						{
							pom = p[0] - 30 -6;
							p[2] = (byte)(6 + pom);
							p[1] = (byte)(54 + pom);
							p[0] = (byte)(25 + pom);
						}
						else if (p[0] >= 44 && p[0] < 58) //5  2.2
						{
							pom = p[0] - 44-2;
							p[2] = (byte)(79 + pom);
							p[1] = (byte)(2 + pom);
							p[0] = (byte)(236 + pom);
						}
						else if (p[0] >= 58 && p[0] < 70) //6  3.8
						{
							pom = p[0] - 58-7;
							p[2] = (byte)(90 + pom);
							p[1] = (byte)(59 + pom);
							p[0] = (byte)(28 + pom);
						}
						else if (p[0] >= 70 && p[0] < 77) //7  3.2
						{
							pom = p[0] - 70-5;
							p[2] = (byte)(74 + pom);
							p[1] = (byte)(73 + pom);
							p[0] = (byte)(87 + pom);
						}
						else if (p[0] >= 77 && p[0] < 82) //8  1.3
						{
							pom = p[0] - 77-3;
							p[2] = (byte)(161 + pom);
							p[1] = (byte)(44 + pom);
							p[0] = (byte)(50 + pom);
						}
						else if (p[0] >= 82 && p[0] < 84) //9  4.5
						{
							pom = p[0] - 82-1;
							p[2] = (byte)(86 + pom);
							p[1] = (byte)(98 + pom);
							p[0] = (byte)(4 + pom);
						}
						else if (p[0] >= 84 && p[0] < 86) //10  2.7
						{
							pom = p[0] - 84-1;
							p[2] = (byte)(42 + pom);
							p[1] = (byte)(102 + pom);
							p[0] = (byte)(106 + pom);
						}
						else if (p[0] >= 86 && p[0] < 93) //11 1.7
						{
							pom = p[0] - 86-2;
							p[2] = (byte)(153 + pom);
							p[1] = (byte)(47 + pom);
							p[0] = (byte)(124 + pom);
						}
						else if (p[0] >= 93 && p[0] < 99) //12 2.3
						{
							pom = p[0] - 93 - 5;
							p[2] = (byte)(45 + pom);
							p[1] = (byte)(105 + pom);
							p[0] = (byte)(203 + pom);
						}
						else if (p[0] >= 99 && p[0] < 106) //13 4.6
						{
							pom = p[0] - 99 - 1;
							p[2] = (byte)(17 + pom);
							p[1] = (byte)(150 + pom);
							p[0] = (byte)(59 + pom);
						}
						else if (p[0] >= 106 && p[0] < 113) //14 4.1
						{
							pom = p[0] - 106 - 6;
							p[2] = (byte)(174 + pom);
							p[1] = (byte)(101 + pom);
							p[0] = (byte)(7 + pom);
						}
						else if (p[0] >= 113 && p[0] < 114) //15 1.6
						{
							pom = p[0] - 113;
							p[2] = (byte)(230 + pom);
							p[1] = (byte)(28 + pom);
							p[0] = (byte)(247 + pom);
						}
						else if (p[0] >= 114 && p[0] < 115) //16 1.2
						{
							pom = p[0] - 114;
							p[2] = (byte)(254);
							p[1] = (byte)(59 + pom);
							p[0] = (byte)(30 + pom);
						}
						else if (p[0] >= 115 && p[0] < 116) //17 2.6
						{
							pom = p[0] - 115;
							p[2] = (byte)(8 + pom);
							p[1] = (byte)(126 + pom);
							p[0] = (byte)(154 + pom);
						}
						else if (p[0] >= 116 && p[0] < 120) //18 1.4
						{
							pom = p[0] - 116;
							p[2] = (byte)(250 + pom);
							p[1] = (byte)(47 + pom);
							p[0] = (byte)(122 + pom);
						}
						else if (p[0] >= 120 && p[0] < 124) //19 3.7
						{
							pom = p[0] - 120 -3;
							p[2] = (byte)(130 + pom);
							p[1] = (byte)(124 + pom);
							p[0] = (byte)(112 + pom);
						}
						else if (p[0] >= 124 && p[0] < 129) //20 2.4
						{
							pom = p[0] - 124;
							p[2] = (byte)(0 + pom);
							p[1] = (byte)(166 + pom);
							p[0] = (byte)(238 + pom);
						}
						else if (p[0] >= 129 && p[0] < 134) //21 3.3
						{
							pom = p[0] - 129 -4;
							p[2] = (byte)(142 + pom);
							p[1] = (byte)(123 + pom);
							p[0] = (byte)(164 + pom);
						}
						else if (p[0] >= 134 && p[0] < 146) //22 4.4
						{
							pom = p[0] - 134;
							p[2] = (byte)(155 + pom);
							p[1] = (byte)(149 + pom);
							p[0] = (byte)(0 + pom);
						}
						else if (p[0] >= 146 && p[0] < 166) //23 4.7
						{
							pom = p[0] - 146 - 12;
							p[2] = (byte)(81 + pom);
							p[1] = (byte)(225 + pom);
							p[0] = (byte)(19 + pom);
						}
						else if (p[0] >= 166 && p[0] < 174) //24 4.8
						{
							pom = p[0] - 166 - 7;
							p[2] = (byte)(8 + pom);
							p[1] = (byte)(253 + pom);
							p[0] = (byte)(204 + pom);
						}
						else if (p[0] >= 174 && p[0] < 177) //25 1.1
						{
							pom = p[0] - 174;
							p[2] = (byte)(214 + pom);
							p[1] = (byte)(160 + pom);
							p[0] = (byte)(144 + pom);
						}
						else if (p[0] >= 177 && p[0] < 180) //26 4.2
						{
							pom = p[0] - 177 - 2;
							p[2] = (byte)(247 + pom);
							p[1] = (byte)(170 + pom);
							p[0] = (byte)(48 + pom);
						}
						else if (p[0] >= 180 && p[0] < 187) //27 3.6
						{
							pom = p[0] - 180;
							p[2] = (byte)(172 + pom);
							p[1] = (byte)(190 + pom);
							p[0] = (byte)(156 + pom);
						}
						else if (p[0] >= 187 && p[0] < 195) //28 1.5
						{
							pom = p[0] - 187 - 6;
							p[2] = (byte)(251 + pom);
							p[1] = (byte)(159 + pom);
							p[0] = (byte)(218 + pom);
						}
						else if (p[0] >= 195 && p[0] < 198) //29 3.4
						{
							pom = p[0] - 195 - 1;
							p[2] = (byte)(183 + pom);
							p[1] = (byte)(192 + pom);
							p[0] = (byte)(255);
						}
						else if (p[0] >= 198 && p[0] < 210) //30 2.5
						{
							pom = p[0] - 198 - 2;
							p[2] = (byte)(111 + pom);
							p[1] = (byte)(235 + pom);
							p[0] = (byte)(255);
						}
						else if (p[0] >= 210 && p[0] < 238) //31 4.3
						{
							pom = p[0] - 210 - 10;
							p[2] = (byte)(244);
							p[1] = (byte)(234 + pom);
							p[0] = (byte)(92 + pom);
						}
						else if (p[0] >= 238 && p[0] <= 255) //32 3.5
						{
							pom = p[0] - 255;
							p[2] = (byte)(255 + pom);
							p[1] = (byte)(255 + pom);
							p[0] = (byte)(255 + pom);
						}

						p += 3;
					}
					p += nOffset;
				}
			}

			b.UnlockBits(bmData);


			return b;
		}


		public static Bitmap GrayscaleToColor24(Bitmap b)
		{

			IList<byte> grayscale = new List<byte>();

			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);

			int stride = bmData.Stride;
			System.IntPtr Scan0 = bmData.Scan0;

			unsafe
			{
				byte* p = (byte*)(void*)Scan0;

				int nOffset = stride - b.Width * 3;

				for (int y = 0; y < b.Height; ++y)
				{
					for (int x = 0; x < b.Width; ++x)
					{
						if (p[0] >= 0 && p[0] < 10) //black
						{
							p[2] = 0;
							p[1] = 0;
							p[0] = 0;
						}
						else if (p[0] >= 10 && p[0] < 20) //dark red
						{
							p[2] = 128;
							p[1] = 0;
							p[0] = 0;
						}
						else if (p[0] >= 20 && p[0] < 27) // dark brown
						{
							p[2] = 64;
							p[1] = 32;
							p[0] = 0;
						}
						else if (p[0] >= 27 && p[0] < 35) //red
						{
							p[2] = 255;
							p[1] = 0;
							p[0] = 0;
						}
						else if (p[0] >= 35 && p[0] < 43) //dark pink
						{
							p[2] = 128;
							p[1] = 10;
							p[0] = 64;
						}
						else if (p[0] >= 43 && p[0] < 48) //dark orange
						{
							p[2] = 128;
							p[1] = 52;
							p[0] = 0;
						}
						else if (p[0] >= 48 && p[0] < 52) //brown
						{
							p[2] = 128;
							p[1] = 64;
							p[0] = 0;
						}
						else if (p[0] >= 52 && p[0] < 55) //dark purple
						{
							p[2] = 89;
							p[1] = 0;
							p[0] = 128;
						}
						else if (p[0] >= 55 && p[0] < 65) //D. dark blue
						{
							p[2] = 0;
							p[1] = 18;
							p[0] = 128;
						}
						else if (p[0] >= 65 && p[0] < 75) //dark green
						{
							p[2] = 0;
							p[1] = 128;
							p[0] = 0;
						}
						else if (p[0] >= 75 && p[0] < 84) //dark yellow
						{
							p[2] = 128;
							p[1] = 107;
							p[0] = 0;
						}
						else if (p[0] == 84) //dark gray
						{
							p[2] = 84;
							p[1] = 84;
							p[0] = 84;
						}
						else if (p[0] > 84 && p[0] < 88) //D. light blue
						{
							p[2] = 0;
							p[1] = 74;
							p[0] = 128;
						}
						else if (p[0] >= 88 && p[0] < 92) //orange
						{
							p[2] = 255;
							p[1] = 104;
							p[0] = 0;
						}
						else if (p[0] >= 92 && p[0] < 99) //pink
						{
							p[2] = 255;
							p[1] = 20;
							p[0] = 128;
						}
						else if (p[0] >= 99 && p[0] < 111) //dark blue
						{
							p[2] = 0;
							p[1] = 36;
							p[0] = 255;
						}
						else if (p[0] >= 111 && p[0] < 124) //dark cyan
						{
							p[2] = 0;
							p[1] = 36;
							p[0] = 255;
						}
						else if (p[0] >= 121 && p[0] < 135) //purple
						{
							p[2] = 178;
							p[1] = 0;
							p[0] = 255;
						}
						else if (p[0] >= 135 && p[0] < 154) //green
						{
							p[2] = 0;
							p[1] = 255;
							p[0] = 0;
						}
						else if (p[0] >= 154 && p[0] < 168) //yellow
						{
							p[2] = 255;
							p[1] = 220;
							p[0] = 0;
						}
						else if (p[0] == 168) //light gray
						{
							p[2] = 168;
							p[1] = 168;
							p[0] = 168;
						}
						else if (p[0] >= 168 && p[0] < 200) //light blue
						{
							p[2] = 0;
							p[1] = 148;
							p[0] = 255;
						}
						else if (p[0] >= 200 && p[0] < 235) //cyan
						{
							p[2] = 0;
							p[1] = 255;
							p[0] = 255;
						}
						else if (p[0] >= 235 && p[0] <= 255) //white
						{
							p[2] = 255;
							p[1] = 255;
							p[0] = 255;
						}

						p += 3;
					}
					p += nOffset;
				}
			}

			b.UnlockBits(bmData);


			return b;
		}


	}
}
