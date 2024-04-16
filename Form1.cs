using lab4_CG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_CG
{

    public partial class Form1 : Form
    {
        Bitmap image;
        private bool isMouseDown = false;
        private Point startPoint;
        private Point endPoint;
        private Rectangle selectionRectangle;

        public Form1()
        {
            InitializeComponent();

        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                image = new Bitmap(Image.FromFile(open.FileName));
                pictureBox1.Image = image;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBox2.Image.Save(save.FileName + ".jpg");
                }
            }
            else
                MessageBox.Show("Please select an image.");

        }

        private void TransformInHSB_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = from_RGB_to_HSB(image);
             
            }
            else
                MessageBox.Show("Please select an image.");

        }

        public Bitmap from_RGB_to_HSB(Bitmap image)
        {
            Color new_pixel;
            Bitmap new_image = new Bitmap(pictureBox1.Image);

            for (int i = 0; i < new_image.Width; i++)
            {
                for (int j = 0; j < new_image.Height; j++)
                {
                    new_pixel = Search_RGB(Search_HSB(new_image.GetPixel(i, j)));
                   
                    new_image.SetPixel(i, j, new_pixel);
                }
            }
            return new_image;
        }
     
        public void from_HSB_to_RGB(Bitmap image)
        {
            if (image != null)
            {
                Bitmap new_image = new Bitmap(image);

                for (int i = 0; i < new_image.Width; i++)
                {
                    for (int j = 0; j < new_image.Height; j++)
                    {
                        Color pixelColor = new_image.GetPixel(i, j);
                        HSB_color hsb = Search_HSB(pixelColor);
                        Color new_pixel = Search_RGB(hsb);
                        new_image.SetPixel(i, j, new_pixel);
                    }

                }
                pictureBox2.Image = new_image;
             
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }

    public double max(Color rgb)
        {
            double Max = rgb.R;
            if (rgb.G > Max)
                Max = rgb.G;
            if (rgb.B > Max)
                Max = rgb.B;
            return Max;
        }

        public double min(Color rgb)
        {
            double Min = rgb.R;
            if (rgb.G < Min)
                Min = rgb.G;
            if (rgb.B < Min)
                Min = rgb.B;
            return Min;
        }

        public HSB_color Search_HSB(Color rgb)
        {
            HSB_color hsb;
            double Max = max(rgb), Min = min(rgb);
            object h = null, s = null, v = null;
            if (Max == Min)
                h = null;
            else if (Max == rgb.R && rgb.G > rgb.B)
                h = 60 * ((rgb.G - rgb.B) / (Max - Min)) + 0;
            else if (Max == rgb.R && rgb.G < rgb.B)
                h = 60 * ((rgb.G - rgb.B) / (Max - Min)) + 360;
            else if (Max == rgb.G)
                h = 60 * ((rgb.B - rgb.R) / (Max - Min)) + 120;
            else if (Max == rgb.B)
                h = 60 * ((rgb.G - rgb.B) / (Max - Min)) + 240;
            if (Convert.ToDouble(h) > 360)
                h = Convert.ToDouble(h) % 360;

            if (Max == 0)
                s = 0;
            else
                s = 1 - (Min * 1.0 / Max);

            v = Max * 1.0 / 255;

            hsb = new HSB_color(Convert.ToDouble(h), Convert.ToDouble(s), Convert.ToDouble(v));
            hsb.a = rgb.A;
            return hsb;
        }

        public Color Search_RGB(HSB_color hsb)
        {
            double H = (Math.Ceiling(hsb.Get_H() / 60)) % 6;
            double f = (hsb.Get_H() / 60) - H;
            double p = hsb.Get_B() * (1 - hsb.Get_S());
            double q = hsb.Get_B() * (1 - f * hsb.Get_S());
            double t = hsb.Get_B() * (1 - (1 - f) * hsb.Get_S());
            double r = 0, g = 0, b = 0, a = 0;

            if (H == 0)
            {
                r = hsb.Get_B(); g = t; b = p;
            }
            if (H == 1)
            {
                r = q; g = hsb.Get_B(); b = p;
            }
            if (H == 2)
            {
                r = p; g = hsb.Get_B(); b = t;
            }
            if (H == 3)
            {
                r = p; g = q; b = hsb.Get_B();
            }
            if (H == 4)
            {
                r = t; g = p; b = hsb.Get_B();
            }
            if (H == 5)
            {
                r = hsb.Get_B(); g = p; b = q;
            }
            r *= 255;
            g *= 255;
            b *= 255;
            if (r > 255) r = 255;
            if (r < 0) r = 0;

            if (g > 255) g = 255;
            if (g < 0) g = 0;

            if (b > 255) b = 255;
            if (b < 0) b = 0;

            return Color.FromArgb((int)hsb.a, (int)r, (int)g, (int)b);
        }
        private void ChangeBrightness(Rectangle imageRect)
        {
            if (image != null)
            {
                Bitmap new_image = new Bitmap(image);

                for (int i = Math.Max(0, imageRect.X); i < Math.Min(imageRect.X + imageRect.Width, new_image.Width); i++)
                {
                    for (int j = Math.Max(0, imageRect.Y); j < Math.Min(imageRect.Y + imageRect.Height, new_image.Height); j++)
                    {
                        Color pixelColor = new_image.GetPixel(i, j);
                        HSB_color hsb = Search_HSB(pixelColor);

                        if (hsb.Get_H() >= 60 && hsb.Get_H() <= 180 && hsb.Get_S() >= 0.5)
                        {
                            hsb.Set_B(hsb.Get_B() + trbBrightnees.Value * 1.0 / 100);
                            Color new_pixel = Search_RGB(hsb);
                            new_image.SetPixel(i, j, new_pixel);
                        }
                    }

                }
                pictureBox2.Image = new_image;
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }

        private void ChangeBrightness(object sender, EventArgs e)
        {
            if (image != null && selectionRectangle != null && selectionRectangle.Width > 0 && selectionRectangle.Height > 0)
            {
                Rectangle imageRect = CalculateImageRect(selectionRectangle);
                ChangeBrightness(imageRect);
                
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (selectionRectangle != null && selectionRectangle.Width > 0 && selectionRectangle.Height > 0)
            {
                e.Graphics.DrawRectangle(Pens.Red, selectionRectangle);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = e.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                endPoint = e.Location;
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int width = Math.Abs(endPoint.X - startPoint.X);
                int height = Math.Abs(endPoint.Y - startPoint.Y);

                selectionRectangle = new Rectangle(x, y, width, height);
                pictureBox2.Invalidate();
            }
            if (image != null)
            {
                int x = e.X;
                int y = e.Y;

                if (x >= 0 && x < pictureBox2.Image.Width && y >= 0 && y < pictureBox2.Image.Height)
                {
                    Color rgbColor = image.GetPixel(x, y);
                    HSB_color hsbColor = Search_HSB(rgbColor);

                    listBox1.Items.Clear();
                    listBox1.Items.Add($"RGB: ({rgbColor.R}, {rgbColor.G}, {rgbColor.B})");
                    listBox2.Items.Clear();
                    listBox2.Items.Add($"HSB: ({Math.Round(hsbColor.Get_H())}, {Math.Round(hsbColor.Get_S(), 2)}, {Math.Round(hsbColor.Get_B(), 2)})");
                }
            }
        }

        private Rectangle CalculateImageRect(Rectangle selectionRect)
        {
            int x = Math.Min(selectionRect.X, selectionRect.X + selectionRect.Width);
            int y = Math.Min(selectionRect.Y, selectionRect.Y + selectionRect.Height);
            int width = Math.Abs(selectionRect.Width);
            int height = Math.Abs(selectionRect.Height);

            Rectangle imageRect = new Rectangle(
                (int)Math.Round((double)(x * pictureBox2.Image.Width) / pictureBox2.Width),
                (int)Math.Round((double)(y * pictureBox2.Image.Height) / pictureBox2.Height),
                (int)Math.Round((double)(width * pictureBox2.Image.Width) / pictureBox2.Width),
                (int)Math.Round((double)(height * pictureBox2.Image.Height) / pictureBox2.Height)
            );

            return imageRect;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Rectangle imageRect = new Rectangle(
                (int)Math.Round((double)(x * pictureBox2.Image.Width) / pictureBox2.Width),
                (int)Math.Round((double)(y * pictureBox2.Image.Height) / pictureBox2.Height),
                (int)Math.Round((double)(width * pictureBox2.Image.Width) / pictureBox2.Width),
                (int)Math.Round((double)(height * pictureBox2.Image.Height) / pictureBox2.Height)
            );

            if (image != null && imageRect.Width > 0 && imageRect.Height > 0)
            {
                ChangeBrightness(imageRect);
            }
            else
            {
                MessageBox.Show("Please select an image and make a selection.");
            }
        }

        private void TransformInRGB_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
               
                from_HSB_to_RGB(image);
         
            }
            else
                MessageBox.Show("Please select an image.");
        }



    }
}



