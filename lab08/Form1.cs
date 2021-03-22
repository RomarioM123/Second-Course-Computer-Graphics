using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;

        //открытие изображения
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Width = image.Width + 40;
                    this.Height = image.Height + 75;
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate(); //????
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //яркость контрастность
        private void яркостьконтрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 BrightnessForm = new Form2(this);
            BrightnessForm.ShowDialog(); //just 'Show' for the control Form1
        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
        }

        //преобразование из UINT32 to Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            image.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image;
        }
		
		static Bitmap GetRgbChannels(Bitmap source)
        {
            //Bitmap result = (Bitmap)source.Clone();
            Color color;

            for (int i = 0; i < source.Width / 2; i++)
            {
                for (int j = 0; j < source.Height / 2; j++)
                {
                    color = source.GetPixel(i, j);
                    image.SetPixel(i, j, Color.FromArgb(color.A, color.R, 0, 0));

                    color = source.GetPixel(i + source.Width / 2, j);
                    image.SetPixel(i + source.Width / 2, j, Color.FromArgb(color.A, 0, color.G, 0));

                    color = source.GetPixel(i, j + source.Height / 2);
                    image.SetPixel(i, j + source.Height / 2, Color.FromArgb(color.A, 0, 0, color.B));

                    color = source.GetPixel(i + source.Width / 2, j + source.Height / 2);
                    byte grey = (byte)(((int)color.A + (int)color.R + (int)color.B + 1) / 3);

                    image.SetPixel(i + source.Width / 2, j + source.Height / 2, Color.FromArgb(color.A, grey, grey, grey));
                }
            }

            //for (int i = 0; i < source.Width/2; i++)
            //{
            //    for (int j = 0; j < source.Height/2; j++)
            //    {
            //        pixel[j,i] = (UInt32)(image.GetPixel(j, i).ToArgb());
            //    }
            //}

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());

            return image;
        }
        private void pictureBox1_Click(object sender, System.EventArgs e){}
 
        private void LoadPicture_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpeg;*.jpg;*.png;*.bmp;*.gif;*.tif;*.ico;*.emf;*.wmf;";
                if (ofd.ShowDialog() == DialogResult.Cancel) 
                    return;
 
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
        private void TransformPicture_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Image = GetRgbChannels((Bitmap)pictureBox1.Image);
        }
    }
}
