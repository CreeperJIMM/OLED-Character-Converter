namespace OLED漢字轉換
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            button8 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            checkBox3 = new System.Windows.Forms.CheckBox();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            checkBox4 = new System.Windows.Forms.CheckBox();
            button11 = new System.Windows.Forms.Button();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(349, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(160, 160);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(8, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(329, 113);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "請輸入漢字";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(8, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(175, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(236, 145);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 45);
            button1.TabIndex = 4;
            button1.Text = "一鍵轉換";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(4, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 20);
            label2.TabIndex = 5;
            label2.Text = "從中選取所需的字(滾輪)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(347, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "預覽";
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(6, 17);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(89, 33);
            button2.TabIndex = 7;
            button2.Text = "選擇字體";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(95, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 20);
            label4.TabIndex = 8;
            label4.Text = "微軟正黑體";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox2.Location = new System.Drawing.Point(4, 308);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(510, 110);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(21, 487);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(157, 39);
            button3.TabIndex = 10;
            button3.Text = "16進制(XBM)預覽工具";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(339, 487);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(135, 39);
            button4.TabIndex = 11;
            button4.Text = "離開";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(374, 14);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(49, 24);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(455, 13);
            numericUpDown2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(49, 24);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(303, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 20);
            label5.TabIndex = 14;
            label5.Text = "偏移量 X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(429, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(19, 20);
            label6.TabIndex = 15;
            label6.Text = "Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(308, 46);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 20);
            label7.TabIndex = 16;
            label7.Text = "容許值 :";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(375, 45);
            numericUpDown3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(128, 24);
            numericUpDown3.TabIndex = 17;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(5, 285);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(200, 20);
            label8.TabIndex = 18;
            label8.Text = "輸出16進制(XBM格式檔)：";
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(12, 426);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(134, 45);
            button5.TabIndex = 19;
            button5.Text = "儲存為圖片檔";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button6.Location = new System.Drawing.Point(182, 426);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(155, 45);
            button6.TabIndex = 20;
            button6.Text = "儲存為二進制文字檔";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(368, 426);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(134, 45);
            button7.TabIndex = 21;
            button7.Text = "儲存為XBM格式檔";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(220, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(92, 24);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "顏色反轉";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox2.Location = new System.Drawing.Point(220, 15);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(92, 24);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "英文全形";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(428, 2);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(83, 23);
            button8.TabIndex = 24;
            button8.Text = "(?)使用說明";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(numericUpDown6);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(4, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(510, 74);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "字體樣式";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(11, 51);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 20);
            label11.TabIndex = 25;
            label11.Text = "字體大小：";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new System.Drawing.Point(101, 47);
            numericUpDown6.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDown6.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new System.Drawing.Size(83, 24);
            numericUpDown6.TabIndex = 24;
            numericUpDown6.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox3.Location = new System.Drawing.Point(208, 284);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(230, 24);
            checkBox3.TabIndex = 24;
            checkBox3.Text = "Adafruit_SSD1306 專用格式";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button9
            // 
            button9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button9.Location = new System.Drawing.Point(198, 487);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(119, 39);
            button9.TabIndex = 26;
            button9.Text = "XBM編輯工具";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(438, 283);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(75, 24);
            button10.TabIndex = 27;
            button10.Text = "💾一鍵複製";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox4.Location = new System.Drawing.Point(251, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(92, 24);
            checkBox4.TabIndex = 28;
            checkBox4.Text = "自動轉換";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // button11
            // 
            button11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button11.Location = new System.Drawing.Point(188, 145);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(42, 45);
            button11.TabIndex = 29;
            button11.Text = "下個";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(405, 191);
            numericUpDown4.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(40, 23);
            numericUpDown4.TabIndex = 24;
            numericUpDown4.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown4.ValueChanged += numericUpDown_Size_ValueChanged;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new System.Drawing.Point(468, 191);
            numericUpDown5.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new System.Drawing.Size(40, 23);
            numericUpDown5.TabIndex = 30;
            numericUpDown5.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown5.ValueChanged += numericUpDown_Size_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(446, 192);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(21, 20);
            label9.TabIndex = 24;
            label9.Text = "×";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(315, 192);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(89, 20);
            label10.TabIndex = 24;
            label10.Text = "像素大小：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(514, 534);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(button11);
            Controls.Add(checkBox4);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(checkBox3);
            Controls.Add(groupBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "OLED漢字轉換  V1.4  BY CreeperJIMM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}
