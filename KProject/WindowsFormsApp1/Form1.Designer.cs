namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFunc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelRadius = new System.Windows.Forms.Label();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSeeBack = new System.Windows.Forms.CheckBox();
            this.pictureBoxFunc = new System.Windows.Forms.PictureBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.textBoxPhase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функция волны";
            // 
            // comboBoxFunc
            // 
            this.comboBoxFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFunc.FormattingEnabled = true;
            this.comboBoxFunc.Items.AddRange(new object[] {
            "sin",
            "cos"});
            this.comboBoxFunc.Location = new System.Drawing.Point(38, 42);
            this.comboBoxFunc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxFunc.Name = "comboBoxFunc";
            this.comboBoxFunc.Size = new System.Drawing.Size(112, 37);
            this.comboBoxFunc.TabIndex = 1;
            this.comboBoxFunc.Text = "sin";
            this.comboBoxFunc.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Радиус сферы - ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxImage.Location = new System.Drawing.Point(499, 3);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(556, 490);
            this.pictureBoxImage.TabIndex = 4;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxImage_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 477);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 53);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(124, 49);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 49);
            this.toolStripMenuItem2.Text = "CLEAR";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(22, 258);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(314, 69);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRadius.Location = new System.Drawing.Point(175, 230);
            this.labelRadius.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(52, 29);
            this.labelRadius.TabIndex = 7;
            this.labelRadius.Text = "100";
            this.labelRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Checked = true;
            this.checkBoxMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMax.Location = new System.Drawing.Point(24, 297);
            this.checkBoxMax.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(360, 36);
            this.checkBoxMax.TabIndex = 8;
            this.checkBoxMax.Text = "Показывать максимумы";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            this.checkBoxMax.CheckedChanged += new System.EventHandler(this.checkBoxMax_CheckedChanged);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMin.Location = new System.Drawing.Point(22, 330);
            this.checkBoxMin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(348, 36);
            this.checkBoxMin.TabIndex = 9;
            this.checkBoxMin.Text = "Показывать минимумы";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            this.checkBoxMin.CheckedChanged += new System.EventHandler(this.checkBoxMin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Частота в рад. (w)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Скорость движения волны - ";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(22, 190);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(316, 69);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Value = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(921, 501);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "FPS:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(977, 499);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(78, 26);
            this.numericUpDown3.TabIndex = 18;
            this.numericUpDown3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelSpeed.Location = new System.Drawing.Point(267, 159);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(52, 29);
            this.labelSpeed.TabIndex = 19;
            this.labelSpeed.Text = "100";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(219, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(51, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "sin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(261, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "(wt + a)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Начальная фаза в град. (a)";
            // 
            // checkBoxSeeBack
            // 
            this.checkBoxSeeBack.AutoSize = true;
            this.checkBoxSeeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSeeBack.Location = new System.Drawing.Point(22, 362);
            this.checkBoxSeeBack.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxSeeBack.Name = "checkBoxSeeBack";
            this.checkBoxSeeBack.Size = new System.Drawing.Size(470, 36);
            this.checkBoxSeeBack.TabIndex = 25;
            this.checkBoxSeeBack.Text = "Показывать с обратной стороны";
            this.checkBoxSeeBack.UseVisualStyleBackColor = true;
            this.checkBoxSeeBack.CheckedChanged += new System.EventHandler(this.checkBoxSeeBack_CheckedChanged);
            // 
            // pictureBoxFunc
            // 
            this.pictureBoxFunc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxFunc.Location = new System.Drawing.Point(24, 396);
            this.pictureBoxFunc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBoxFunc.Name = "pictureBoxFunc";
            this.pictureBoxFunc.Size = new System.Drawing.Size(452, 87);
            this.pictureBoxFunc.TabIndex = 26;
            this.pictureBoxFunc.TabStop = false;
            this.pictureBoxFunc.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFunc_Paint);
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFreq.Location = new System.Drawing.Point(332, 80);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFreq.MaxLength = 16;
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(109, 35);
            this.textBoxFreq.TabIndex = 27;
            this.textBoxFreq.Text = "0";
            this.textBoxFreq.TextChanged += new System.EventHandler(this.textBoxWave_TextChanged);
            // 
            // textBoxPhase
            // 
            this.textBoxPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhase.Location = new System.Drawing.Point(332, 119);
            this.textBoxPhase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhase.MaxLength = 16;
            this.textBoxPhase.Name = "textBoxPhase";
            this.textBoxPhase.Size = new System.Drawing.Size(109, 35);
            this.textBoxPhase.TabIndex = 28;
            this.textBoxPhase.Text = "0";
            this.textBoxPhase.TextChanged += new System.EventHandler(this.textBoxWave_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 530);
            this.Controls.Add(this.textBoxPhase);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.pictureBoxFunc);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSeeBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxMin);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.comboBoxFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Text = "Waves Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSeeBack;
        private System.Windows.Forms.PictureBox pictureBoxFunc;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.TextBox textBoxPhase;
        private System.Windows.Forms.CheckBox checkBoxMax;
    }
}

