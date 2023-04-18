namespace vzlom_rsa
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.richTextBox_q = new System.Windows.Forms.RichTextBox();
            this.richTextBox_p = new System.Windows.Forms.RichTextBox();
            this.button_run_factorizachiya = new System.Windows.Forms.Button();
            this.richTextBox_N = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "p";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "q";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(-48, 146);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(17, 16);
            this.label_N.TabIndex = 10;
            this.label_N.Text = "N";
            // 
            // richTextBox_q
            // 
            this.richTextBox_q.Location = new System.Drawing.Point(523, 95);
            this.richTextBox_q.Name = "richTextBox_q";
            this.richTextBox_q.Size = new System.Drawing.Size(382, 30);
            this.richTextBox_q.TabIndex = 6;
            this.richTextBox_q.Text = "";
            // 
            // richTextBox_p
            // 
            this.richTextBox_p.Location = new System.Drawing.Point(523, 29);
            this.richTextBox_p.Name = "richTextBox_p";
            this.richTextBox_p.Size = new System.Drawing.Size(382, 30);
            this.richTextBox_p.TabIndex = 7;
            this.richTextBox_p.Text = "";
            // 
            // button_run_factorizachiya
            // 
            this.button_run_factorizachiya.Location = new System.Drawing.Point(363, 134);
            this.button_run_factorizachiya.Name = "button_run_factorizachiya";
            this.button_run_factorizachiya.Size = new System.Drawing.Size(105, 35);
            this.button_run_factorizachiya.TabIndex = 5;
            this.button_run_factorizachiya.Text = "run";
            this.button_run_factorizachiya.UseVisualStyleBackColor = true;
            this.button_run_factorizachiya.Click += new System.EventHandler(this.button_run_factorizachiya_Click);
            // 
            // richTextBox_N
            // 
            this.richTextBox_N.Location = new System.Drawing.Point(12, 29);
            this.richTextBox_N.Name = "richTextBox_N";
            this.richTextBox_N.Size = new System.Drawing.Size(458, 96);
            this.richTextBox_N.TabIndex = 4;
            this.richTextBox_N.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1072, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "sec";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(926, 43);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(14, 16);
            this.label_time.TabIndex = 11;
            this.label_time.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 147);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(533, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(653, 468);
            this.listBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 681);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.richTextBox_q);
            this.Controls.Add(this.richTextBox_p);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_run_factorizachiya);
            this.Controls.Add(this.richTextBox_N);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.RichTextBox richTextBox_q;
        private System.Windows.Forms.RichTextBox richTextBox_p;
        private System.Windows.Forms.Button button_run_factorizachiya;
        private System.Windows.Forms.RichTextBox richTextBox_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

