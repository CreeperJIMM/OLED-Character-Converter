using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OLED漢字轉換
{
    public partial class Form3 : Form
    {
        static int size = 16;
        int[,] dots = new int[size, size];
        bool Adafruit = true;
        public Form3(int[,]? d)
        {
            InitializeComponent();
            if (d != null)
            {
                dots = d;
                size = dots.GetLength(0);
                richTextBox1.Text = ToXBMFormat();
                pictureBox1.Refresh();
            }
            numericUpDown4.Value = numericUpDown5.Value = size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "圖片檔(16x16)|*.jpg;*.png;*.jpeg";
            dialog.Title = "開啟二進制文本";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(dialog.FileName);
                    if (bitmap.Width != bitmap.Height) throw new Exception("error");
                    size = bitmap.Height;
                    dots = new int[size, size];
                    for (int i = 0; i < dots.GetLength(0); i++)
                    {
                        for (int j = 0; j < dots.GetLength(1); j++)
                        {
                            Color c = bitmap.GetPixel(i, j);
                            int a = (c.R + c.G + c.B) / 3;
                            if (a > 100) dots[i, j] = 1;
                            else dots[i, j] = 0;
                        }
                    }
                    richTextBox1.Text = ToXBMFormat();
                    pictureBox1.Refresh();
                }
                catch
                {
                    MessageBox.Show("圖片格式有誤，請再試一遍！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "二進制文本|*.txt";
            dialog.Title = "開啟二進制文本";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] file = File.ReadAllLines(dialog.FileName);
                try
                {
                    size = file.Length;
                    dots = new int[size, size];
                    for (int i = 0; i < file.Length; i++)
                    {
                        string[] bin = file[i].ToCharArray().Select(m => m.ToString()).ToArray();
                        for (int j = 0; j < bin.Length; j++)
                        {
                            dots[i, j] = int.Parse(bin[j]);
                        }
                    }
                    richTextBox1.Text = ToXBMFormat();
                    pictureBox1.Refresh();
                }
                catch
                {
                    MessageBox.Show("文本有誤，請再試一遍！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "xbm文本|*.txt";
            dialog.Title = "開啟xbm文本";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(dialog.FileName);
                ReadXBMFile(file);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string txt = inputDialog.txt;
                if (txt == "") return;
                ReadXBMFile(txt);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            bool allblack = true;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (dots[i, j] == 1) allblack = false;
            dots = new int[size, size];
            if (allblack)
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        dots[i, j] = 1;
            richTextBox1.Text = ToXBMFormat();
            pictureBox1.Refresh();
        }

        private void ReadXBMFile(string file)
        {
            try
            {
                string[] str = file.Replace("\r\n", "").Replace("\n", "").Replace(" ", "").Split(',');
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
                        dots[j, i] = int.Parse(binary[index].ToString());
                        index++;
                    }
                }
                richTextBox1.Text = ToXBMFormat();
                pictureBox1.Refresh();
            }
            catch
            {
                MessageBox.Show("文本有誤，請再試一遍！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Adafruit = checkBox1.Checked;
            richTextBox1.Text = ToXBMFormat();
            pictureBox1.Refresh();
        }
        private void numericUpDown_Size_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            size = (int)numeric.Value;
            numericUpDown4.Value = size;
            numericUpDown5.Value = size;
            int[,] tmp = new int[size, size];
            int min = Math.Min(dots.GetLength(0), size);
            for (int i = 0; i < min; i++)
                for (int j = 0; j < min; j++)
                    tmp[i, j] = dots[i, j];
            dots = tmp;
            richTextBox1.Text = ToXBMFormat();
            pictureBox1.Refresh();
        }
        Point last = new Point(-1, -1);
        int option = 0;
        private void Change_Pen_Option(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                int a = int.Parse($"0{radioButton.Tag}");
                option = a;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse(e);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Mouse(e);
        }
        private void Mouse(MouseEventArgs e)
        {
            float w = pictureBox1.Width / (float)size;
            float h = pictureBox1.Height / (float)size;
            int x = (int)(e.X / w);
            int y = (int)(e.Y / h);
            if (e.Button == MouseButtons.Left)
            {
                if (x < 0 || y < 0 || x > size - 1 || y > size - 1) return;
                if (last.X == x && last.Y == y) return;
                last = new Point(x, y);
                if (option == 0)
                {
                    if (dots[x, y] == 1)
                        dots[x, y] = 0;
                    else
                        dots[x, y] = 1;
                }
                else if (option == 1)
                    dots[x, y] = 1;
                else if (option == 2)
                    dots[x, y] = 0;
                richTextBox1.Text = ToXBMFormat();
                pictureBox1.Refresh();
                GC.Collect();
            }
            else
            {
                last = new Point(-1, -1);
            }
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
                    if (dots[i, j] == 1) brush = new SolidBrush(Color.White);
                    graphics.FillRectangle(brush, i * width, j * height, width, height);
                }
            }
            for (int i = 0; i < size; i++)
            {
                graphics.DrawLine(pen, 0, i * height, pictureBox1.Width, i * height);
                graphics.DrawLine(pen, i * width, 0, i * width, pictureBox1.Height);
            }
        }
        private string ToXBMFormat()
        {
            string tmp = "";
            int len = 0;
            numericUpDown4.Value = numericUpDown5.Value = size;
            List<string> list = new List<string>();
            for (int i = 0; i < dots.GetLength(0); i++)
            {
                for (int j = 0; j < dots.GetLength(1); j++)
                {
                    tmp = dots[j, i] + tmp;
                    len++;
                    if (tmp.Length >= 8)
                    {
                        if (Adafruit) tmp = string.Join("", tmp.ToCharArray().Reverse());
                        list.Add(To16(tmp));
                        tmp = "";
                    }
                }
            }
            if (tmp.Length > 0) list.Add(To16(tmp));
            if (list.Count <= 32) list.Insert((list.Count / 2), "\r\n");
            else
                for (int i = 15; i < list.Count; i += 16)
                    list.Insert(i, "\r\n");
            string result = string.Join(',', list.ToArray()).Replace("\r\n,", "\r\n");
            return result;
        }
        private string To16(string bin)
        {
            int a = Convert.ToInt32(bin, 2);
            string c = $"{Convert.ToString(a, 16)}".PadLeft(2, '0');
            return $"0x{c}";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") return;
            Clipboard.SetText(richTextBox1.Text);
            MessageBox.Show("已複製到剪貼簿", "複製成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
