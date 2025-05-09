using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OLED漢字轉換
{
    public partial class Form2 : Form
    {
        static int size = 16;
        int[,] dots = new int[size, size];
        bool Adafruit = true;
        public Form2(int[,]? d, string? text)
        {
            InitializeComponent();
            if (d != null && text != null)
            {
                size = d.GetLength(0);
                dots = new int[size, size];

                for (int i = 0; i < d.GetLength(0); i++)
                    for (int j = 0; j < d.GetLength(1); j++)
                        dots[i, j] = d[j, i];
                richTextBox1.Text = text;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = richTextBox1.Text.Replace("\n", "").Replace(" ", "").Split(',');
                string binary = "";
                for (int i = 0; i < str.Length; i++)
                {
                    int a = Convert.ToInt32(str[i], 16);
                    if (Adafruit)
                        binary += string.Join("", Convert.ToString(a, 2).PadLeft(8, '0'));
                    else
                        binary += string.Join("", Convert.ToString(a, 2).PadLeft(8, '0').Reverse());
                }
                size = GetXBMSize(binary.Length);
                dots = new int[size, size];
                int index = 0;
                for (int i = 0; i < dots.GetLength(0); i++)
                {
                    for (int j = 0; j < dots.GetLength(1); j++)
                    {
                        dots[i, j] = int.Parse(binary[index].ToString());
                        index++;
                    }
                }
                pictureBox1.Refresh();
                pictureBox2.Refresh();
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch
            {
                richTextBox1.Text = "字串格式有錯誤，必須為16進制的XBM格式，請檢查之後再試一遍！";
            }
        }
        private int GetXBMSize(int len)
        {
            for (int i = 8; i < 128; i++)
            {
                int a = i * i;
                int b = (i + 1) * (i + 1);
                if (a <= len && len < b) return i;
            }
            return 0;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);
            Pen pen = new Pen(Color.FromArgb(120, 184, 184, 184), 0.5f);
            float width = pictureBox1.Width / (float)size;
            float height = pictureBox1.Height / (float)size;
            for (int i = 0; i < dots.GetLength(0); i++)
            {
                for (int j = 0; j < dots.GetLength(1); j++)
                {
                    Brush brush = new SolidBrush(Color.Black);
                    if (dots[j, i] == 1) brush = new SolidBrush(Color.White);
                    graphics.FillRectangle(brush, i * width, j * height, width, height);
                }
            }
            for (int i = 0; i < size; i++)
            {
                graphics.DrawLine(pen, 0, i * height, pictureBox1.Width, i * height);
                graphics.DrawLine(pen, i * width, 0, i * width, pictureBox1.Height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = GetImage(false);
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "PNG檔|*.png|JPG檔|*.jpg";
            save.FileName = $"image";
            save.DefaultExt = "png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = GetImage(true);
            Bitmap bg = Resource1.Image1;
            Graphics graphics = e.Graphics;
            PointF DPI = GetDPI(graphics);
            float scale = DPI.X / 96;
            graphics.Clear(Color.White);
            graphics.DrawImage(bg, 0, 0);
            graphics.DrawImage(bitmap, 13 * scale, 40 * scale, size * scale, size * scale);
        }
        private PointF GetDPI(Graphics g)
        {
            return new PointF(g.DpiX, g.DpiY);
        }
        private Bitmap GetImage(bool isblue)
        {
            Bitmap bitmap = new Bitmap(size, size);
            for (int i = 0; i < dots.GetLength(0); i++)
            {
                for (int j = 0; j < dots.GetLength(1); j++)
                {
                    if (dots[i, j] == 1) bitmap.SetPixel(j, i, Color.White);
                    else if (dots[i, j] == 0)
                        if (isblue)
                            bitmap.SetPixel(j, i, Color.FromArgb(53, 43, 77));
                        else
                            bitmap.SetPixel(j, i, Color.Black);
                }
            }
            return bitmap;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Adafruit = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "文字檔|*.txt";
            save.FileName = $"binary";
            save.DefaultExt = "txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string bin = "";
                for (int i = 0; i < dots.GetLength(0); i++)
                {
                    for (int j = 0; j < dots.GetLength(1); j++)
                    {
                        bin += $"{dots[i, j]}";
                    }
                    if (i < dots.GetLength(0) - 1) bin += "\r\n";
                }
                File.WriteAllText(save.FileName, bin);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(DataFormats.Text))
            {
                richTextBox1.Text = Clipboard.GetText();
            }
        }
    }
}
