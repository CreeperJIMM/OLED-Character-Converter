namespace OLED漢字轉換
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            checkBox1 = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            groupBox2 = new System.Windows.Forms.GroupBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(274, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(230, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Adafruit_SSD1306 專用格式";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(2, 425);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(184, 20);
            label2.TabIndex = 29;
            label2.Text = "輸出16進制(XBM格式)：";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(2, 448);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(500, 110);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(10, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 20);
            label3.TabIndex = 27;
            label3.Text = "點擊方格來修改點陣資料";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(10, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(320, 320);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(8, 26);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(134, 47);
            button1.TabIndex = 1;
            button1.Text = "開啟圖片檔";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(8, 99);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(134, 47);
            button2.TabIndex = 2;
            button2.Text = "開啟二進制檔";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(8, 170);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(134, 47);
            button3.TabIndex = 3;
            button3.Text = "開啟XBM檔";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(421, 420);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(80, 28);
            button10.TabIndex = 13;
            button10.Text = "💾一鍵複製";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(8, 242);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(134, 47);
            button4.TabIndex = 4;
            button4.Text = "手動輸入XBM檔";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(129, 18);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(93, 40);
            button5.TabIndex = 5;
            button5.Text = "清除畫布";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new System.Drawing.Point(344, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(156, 320);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "開啟檔案";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(51, 27);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(21, 20);
            label9.TabIndex = 41;
            label9.Text = "×";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new System.Drawing.Point(73, 26);
            numericUpDown5.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new System.Drawing.Size(40, 23);
            numericUpDown5.TabIndex = 7;
            numericUpDown5.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown5.ValueChanged += numericUpDown_Size_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(10, 26);
            numericUpDown4.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(40, 23);
            numericUpDown4.TabIndex = 6;
            numericUpDown4.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown4.ValueChanged += numericUpDown_Size_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Location = new System.Drawing.Point(10, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(490, 68);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "畫布設定";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton3.Location = new System.Drawing.Point(400, 36);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(68, 22);
            radioButton3.TabIndex = 10;
            radioButton3.Tag = "2";
            radioButton3.Text = "僅黑色";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += Change_Pen_Option;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton2.Location = new System.Drawing.Point(326, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(68, 22);
            radioButton2.TabIndex = 9;
            radioButton2.Tag = "1";
            radioButton2.Text = "僅白色";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += Change_Pen_Option;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton1.Location = new System.Drawing.Point(238, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(82, 22);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Tag = "0";
            radioButton1.Text = "反轉像素";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += Change_Pen_Option;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(237, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 18);
            label1.TabIndex = 44;
            label1.Text = "筆刷設定";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button10);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "XBM格式編輯工具";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}