using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OLED漢字轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font font = new Font("微軟正黑體", 12);
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            char[] chars = richTextBox1.Text.ToCharArray();
            foreach (char s in chars)
            {
                if (s != ' ') comboBox1.Items.Add(s);
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            else comboBox1.Text = "";
            StringToImage();
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                label4.Text = font.Name;
            }
            numericUpDown6.Value = (int)font.Size;
            StringToImage();
            pictureBox1.Refresh();
        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            font = new Font($"{font.Name}", (int)numericUpDown6.Value, font.Style, font.Unit);
            StringToImage();
            pictureBox1.Refresh();
        }
        int x = 0;
        int y = 0;
        int allow = 100;
        bool reverse = false;
        bool full = true;
        bool Adafruit = true;
        bool Auto = true;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0) return;
            StringToImage();
            pictureBox1.Refresh();
            GC.Collect();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x = (int)numericUpDown1.Value;
            y = (int)numericUpDown2.Value;
            allow = (int)numericUpDown3.Value;
            StringToImage();
            pictureBox1.Refresh();
            GC.Collect();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reverse = checkBox1.Checked;
            StringToImage();
            pictureBox1.Refresh();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            full = checkBox2.Checked;
            StringToImage();
            pictureBox1.Refresh();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Adafruit = checkBox3.Checked;
            StringToImage();
            pictureBox1.Refresh();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Auto) button1_Click(sender, e);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Auto = checkBox4.Checked;
            button1.Enabled = !Auto;
        }
        static int size = 16;
        Bitmap bitmap = new Bitmap(size, size);
        int[,] dots = new int[size, size];
        private void numericUpDown_Size_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            size = (int)numeric.Value;
            numericUpDown4.Value = size;
            numericUpDown5.Value = size;
            StringToImage();
            pictureBox1.Refresh();
        }
        private void StringToImage()
        {
            richTextBox2.Text = "";
            dots = new int[size, size];
            if (comboBox1.Items.Count <= 0) return;
            char s = comboBox1.Items[comboBox1.SelectedIndex].ToString().ToCharArray()[0];
            if (full && s >= 0 && s <= 128)
                s = (char)(s + 65248);
            bitmap = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(bitmap);
            PointF DPI = GetDPI(g);
            g.ScaleTransform(100 / DPI.X, 100 / DPI.Y);
            g.Clear(Color.Black);
            g.DrawString($"{s}", font, new SolidBrush(Color.White), new PointF(-4 + x, -3 + y));
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c = bitmap.GetPixel(i, j);
                    int a = (c.R + c.G + c.B) / 3;
                    if (a >= allow)
                        if (reverse) dots[i, j] = 0;
                        else dots[i, j] = 1;
                    else
                        if (reverse) dots[i, j] = 1;
                    else dots[i, j] = 0;
                }
            }
            string code = ToXBMFormat();
            richTextBox2.Text = code;
            GC.Collect();
        }
        private PointF GetDPI(Graphics g)
        {
            return new PointF(g.DpiX, g.DpiY);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0)
            {
                Form2 form2 = new Form2(null, null);
                form2.ShowDialog();
                form2.Close();
            }
            else
            {
                Form2 form2 = new Form2(dots, ToXBMFormat());
                form2.ShowDialog();
                form2.Close();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0)
            {
                Form3 form3 = new Form3(null);
                form3.ShowDialog();
                form3.Close();
            }
            else
            {
                Form3 form3 = new Form3(dots);
                form3.ShowDialog();
                form3.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        //儲存為圖片
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "PNG檔|*.png|JPG檔|*.jpg";
            save.FileName = $"{comboBox1.SelectedItem}";
            save.DefaultExt = "png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName);
            }
        }
        //儲存為二進制
        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "文字檔|*.txt";
            save.FileName = $"{comboBox1.SelectedItem}";
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
        //儲存為XBM
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "文字檔|*.txt|Xbm檔案|*.xbm|C語言檔案|*.c";
            save.FileName = $"{comboBox1.SelectedItem}";
            save.DefaultExt = "txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string Ext = Path.GetExtension(save.FileName);
                string code = ToXBMFormat();
                if (Ext == ".txt")
                {
                    File.WriteAllText(save.FileName, code);
                }
                else if (Ext == ".xbm")
                {
                    string code2 = $"#define keyboard{size}_width {size}\r\n#define keyboard{size}_height {size}\r\n" +
                        $"static char keyboard{size}_bits[] = {{\r\n{code}\r\n}};";
                    File.WriteAllText(save.FileName, code2);
                }
                else if (Ext == ".c")
                {
                    string code2 = $"const unsigned char image_data = {{\r\n{code}\r\n}};";
                    File.WriteAllText(save.FileName, code2);
                }
            }
        }

        private string ToXBMFormat()
        {
            string tmp = "";
            int len = 0;
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
            return string.Join(',', list.ToArray()).Replace("\r\n,", "\r\n");
        }
        private string To16(string bin)
        {
            int a = Convert.ToInt32(bin, 2);
            string c = $"{Convert.ToString(a, 16)}".PadLeft(2, '0');
            return $"0x{c}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string help = "歡迎使用漢字轉XBM工具\n該工具可以將字做成Arduino OLED的字體庫\n" +
                "並且輸出大小為16x16的XBM格式。\n\n使用說明：\n將需要轉換的字串打在輸入漢字的區域，\n" +
                "然後按下一鍵轉換後從選單挑選需要的字元使用！\n並且你可以調整字體、大小、偏移量與容許值等。\n" +
                "除了可輸出中文以外還能輸出英文與數字，預設勾選英文全形功能，\n該功能可以讓英文與數字置中。\n" +
                "調整完後就可以直接複製輸出欄的XBM格式資料，\n並且也可以輸出為圖片檔、二進制與XBM文字檔等。\n" +
                "\n額外工具：\n預覽工具：可驗證XBM格式是否正確，並且可以看到OLED預覽的樣子。\n" +
                "編輯工具：可編輯已輸出的字元，能將輸出的字元不對稱或有不滿意的地方去做修改。\n" +
                "\n更新日記：\n" +
                "1.2(23.11.3a) 修復高DPI預覽框與輸出會超過框框的問題\n      並且新增Arduino OLED(Adafruit_SSD1306)專用格式。\n" +
                "1.3(23.11.3a) 新增編輯工具、自動轉換、複製到剪貼簿功能。\n" +
                "1.4(23.11.9a) 新增調整大小功能，新增從剪貼簿貼上功能，修復各種bug。" +
                "\n製作 BY CreeperJIMM\n版本 1.4(23.11.9a)\n";

            MessageBox.Show(help, "使用說明", MessageBoxButtons.OK);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") return;
            Clipboard.SetText(richTextBox2.Text);
            MessageBox.Show("已複製到剪貼簿", "複製成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count <= 0) return;
            int n = comboBox1.Items.Count;
            if (comboBox1.SelectedIndex == n - 1)
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex++;
        }
    }
}
