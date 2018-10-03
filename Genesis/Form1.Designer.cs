namespace Genesis
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
            this.btnStart = new System.Windows.Forms.Button();
            this.genBeauty = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBeautyPercent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numPopulationSurvival = new System.Windows.Forms.NumericUpDown();
            this.numPopulationBonusSurvival = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numBeautyPresent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPresent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 251);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(421, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Пуск эмуляции";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // genBeauty
            // 
            this.genBeauty.Location = new System.Drawing.Point(101, 8);
            this.genBeauty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genBeauty.Name = "genBeauty";
            this.genBeauty.Size = new System.Drawing.Size(330, 26);
            this.genBeauty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ген красоты";
            // 
            // lblBeautyPercent
            // 
            this.lblBeautyPercent.AutoSize = true;
            this.lblBeautyPercent.Location = new System.Drawing.Point(258, 36);
            this.lblBeautyPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeautyPercent.Name = "lblBeautyPercent";
            this.lblBeautyPercent.Size = new System.Drawing.Size(21, 13);
            this.lblBeautyPercent.TabIndex = 3;
            this.lblBeautyPercent.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер популяции";
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPopulationSize.Location = new System.Drawing.Point(151, 60);
            this.numPopulationSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopulationSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(93, 20);
            this.numPopulationSize.TabIndex = 5;
            this.numPopulationSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPopulationSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numPopulationSize_Scroll);
            // 
            // numPopulationSurvival
            // 
            this.numPopulationSurvival.Location = new System.Drawing.Point(151, 88);
            this.numPopulationSurvival.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSurvival.Name = "numPopulationSurvival";
            this.numPopulationSurvival.Size = new System.Drawing.Size(120, 20);
            this.numPopulationSurvival.TabIndex = 6;
            this.numPopulationSurvival.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSurvival.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numPopulationSurvival.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numPopulationSurvival_Scroll);
            // 
            // numPopulationBonusSurvival
            // 
            this.numPopulationBonusSurvival.Location = new System.Drawing.Point(151, 116);
            this.numPopulationBonusSurvival.Name = "numPopulationBonusSurvival";
            this.numPopulationBonusSurvival.Size = new System.Drawing.Size(120, 20);
            this.numPopulationBonusSurvival.TabIndex = 7;
            this.numPopulationBonusSurvival.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numPopulationBonusSurvival.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numPopulationBonusSurvival_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Базовая выживаемость ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Бонусная выживаемость ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(151, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numBeautyPresent
            // 
            this.numBeautyPresent.Location = new System.Drawing.Point(151, 168);
            this.numBeautyPresent.Name = "numBeautyPresent";
            this.numBeautyPresent.Size = new System.Drawing.Size(120, 20);
            this.numBeautyPresent.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кол-во потомков ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во особей с геном";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBeautyPresent);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPopulationBonusSurvival);
            this.Controls.Add(this.numPopulationSurvival);
            this.Controls.Add(this.numPopulationSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBeautyPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genBeauty);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Genesis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPresent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar genBeauty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBeautyPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.NumericUpDown numPopulationSurvival;
        private System.Windows.Forms.NumericUpDown numPopulationBonusSurvival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numBeautyPresent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

