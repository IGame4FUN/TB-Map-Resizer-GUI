using System;
using System.Drawing;

namespace WinFormsApp1 {
    class Class1 {
		private static Color HSLToRGB(int H, float S, float L)
		{
			byte r = 0;
			byte g = 0;
			byte b = 0;

			if (S == 0)
			{
				r = g = b = (byte)(L * 255);
			}
			else
			{
				float v1, v2;
				float hue = (float)H / 360;

				v2 = (L < 0.5) ? (L * (1 + S)) : ((L + S) - (L * S));
				v1 = 2 * L - v2;

				r = (byte)(255 * HueToRGB(v1, v2, hue + (1.0f / 3)));
				g = (byte)(255 * HueToRGB(v1, v2, hue));
				b = (byte)(255 * HueToRGB(v1, v2, hue - (1.0f / 3)));
			}

			Color color = Color.FromArgb(r, g, b);

			return color;
		}
		private static float HueToRGB(float v1, float v2, float vH)
		{
			if (vH < 0)
				vH += 1;

			if (vH > 1)
				vH -= 1;

			if ((6 * vH) < 1)
				return (v1 + (v2 - v1) * 6 * vH);

			if ((2 * vH) < 1)
				return v2;

			if ((3 * vH) < 2)
				return (v1 + (v2 - v1) * ((2.0f / 3) - vH) * 6);

			return v1;
		}

		public static void Draw(ref int[] heights, ref Bitmap image1, int H = 16, float S = 0.85F, float L = 0.45F)
        {
			Color[] color_heights = new Color[16];

			for (int i = 0; i < 16; i++) // making new colors
				color_heights[15 - i] = HSLToRGB(i * H, S, L);

			using (Graphics graphics = Graphics.FromImage(image1))
			{ 
				for (int x = 0; x < image1.Size.Width; x++) // filling pixels
					for (int y = 0; y < image1.Size.Height; y++)
						image1.SetPixel(x, y, color_heights[heights[x * image1.Size.Width + y]]);
			}
		}

		public static Bitmap Zoom(Bitmap image1, float zoom_level)
		{
			Bitmap image1_zoomed = new Bitmap((int)Math.Round(image1.Size.Width * zoom_level), (int)Math.Round(image1.Size.Height * zoom_level));
			using (Graphics graphics = Graphics.FromImage(image1_zoomed)) //drawing zoomed image
			{
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
				graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;

				graphics.DrawImage(image1, new Rectangle(Point.Empty, image1_zoomed.Size));
			}

			return image1_zoomed;
		}
	}
}
