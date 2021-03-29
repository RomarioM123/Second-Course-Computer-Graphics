namespace lab09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShearY = new System.Windows.Forms.TextBox();
            this.panelbm = new System.Windows.Forms.Panel();
            this.tbTranslationY = new System.Windows.Forms.TextBox();
            this.tbTranslationX = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbShearX = new System.Windows.Forms.TextBox();
            this.tbRotaionAngle = new System.Windows.Forms.TextBox();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тЫКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelbm.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(147, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 483);
            this.panel1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(19, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(27, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(26, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Угол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // tbShearY
            // 
            this.tbShearY.Location = new System.Drawing.Point(78, 267);
            this.tbShearY.Name = "tbShearY";
            this.tbShearY.Size = new System.Drawing.Size(50, 20);
            this.tbShearY.TabIndex = 12;
            this.tbShearY.Text = "0";
            // 
            // panelbm
            // 
            this.panelbm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelbm.Controls.Add(this.button2);
            this.panelbm.Controls.Add(this.tbShearX);
            this.panelbm.Controls.Add(this.button1);
            this.panelbm.Controls.Add(this.tbShearY);
            this.panelbm.Controls.Add(this.tbRotaionAngle);
            this.panelbm.Controls.Add(this.textBox4);
            this.panelbm.Controls.Add(this.label8);
            this.panelbm.Controls.Add(this.label3);
            this.panelbm.Controls.Add(this.tbScaleX);
            this.panelbm.Controls.Add(this.label9);
            this.panelbm.Controls.Add(this.textBox2);
            this.panelbm.Controls.Add(this.label5);
            this.panelbm.Controls.Add(this.label2);
            this.panelbm.Controls.Add(this.label1);
            this.panelbm.Controls.Add(this.tbTranslationY);
            this.panelbm.Controls.Add(this.textBox3);
            this.panelbm.Controls.Add(this.tbTranslationX);
            this.panelbm.Controls.Add(this.textBox1);
            this.panelbm.Location = new System.Drawing.Point(5, 41);
            this.panelbm.Name = "panelbm";
            this.panelbm.Size = new System.Drawing.Size(136, 371);
            this.panelbm.TabIndex = 26;
            // 
            // tbTranslationY
            // 
            this.tbTranslationY.Location = new System.Drawing.Point(78, 55);
            this.tbTranslationY.Name = "tbTranslationY";
            this.tbTranslationY.Size = new System.Drawing.Size(50, 20);
            this.tbTranslationY.TabIndex = 5;
            this.tbTranslationY.Text = "0";
            // 
            // tbTranslationX
            // 
            this.tbTranslationX.Location = new System.Drawing.Point(78, 31);
            this.tbTranslationX.Name = "tbTranslationX";
            this.tbTranslationX.Size = new System.Drawing.Size(50, 20);
            this.tbTranslationX.TabIndex = 4;
            this.tbTranslationX.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Location = new System.Drawing.Point(10, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(118, 20);
            this.textBox4.TabIndex = 30;
            this.textBox4.Text = "Сдвиг";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Location = new System.Drawing.Point(10, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "Поворот";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Location = new System.Drawing.Point(10, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "Масштабирование";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(10, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Перемещение";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbShearX
            // 
            this.tbShearX.Location = new System.Drawing.Point(78, 241);
            this.tbShearX.Name = "tbShearX";
            this.tbShearX.Size = new System.Drawing.Size(50, 20);
            this.tbShearX.TabIndex = 11;
            this.tbShearX.Text = "0";
            // 
            // tbRotaionAngle
            // 
            this.tbRotaionAngle.Location = new System.Drawing.Point(78, 178);
            this.tbRotaionAngle.Name = "tbRotaionAngle";
            this.tbRotaionAngle.Size = new System.Drawing.Size(50, 20);
            this.tbRotaionAngle.TabIndex = 8;
            this.tbRotaionAngle.Text = "0";
            // 
            // tbScaleX
            // 
            this.tbScaleX.Location = new System.Drawing.Point(78, 116);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(50, 20);
            this.tbScaleX.TabIndex = 6;
            this.tbScaleX.Text = "1";
            this.tbScaleX.TextChanged += new System.EventHandler(this.tbScaleX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Коэфф.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тЫКToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // тЫКToolStripMenuItem
            // 
            this.тЫКToolStripMenuItem.Name = "тЫКToolStripMenuItem";
            this.тЫКToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тЫКToolStripMenuItem.Text = "ТЫК";
            this.тЫКToolStripMenuItem.Click += new System.EventHandler(this.тЫКToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(606, 535);
            this.Controls.Add(this.panelbm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelbm.ResumeLayout(false);
            this.panelbm.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShearY;
        private System.Windows.Forms.Panel panelbm;
        private System.Windows.Forms.TextBox tbShearX;
        private System.Windows.Forms.TextBox tbRotaionAngle;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.TextBox tbTranslationY;
        private System.Windows.Forms.TextBox tbTranslationX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тЫКToolStripMenuItem;
    }
}

