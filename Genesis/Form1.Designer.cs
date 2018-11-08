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
            this.numChildrenNumber = new System.Windows.Forms.NumericUpDown();
            this.numBeautyPercent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.radGenPercent = new System.Windows.Forms.RadioButton();
            this.radGenCount = new System.Windows.Forms.RadioButton();
            this.numBeautyCount = new System.Windows.Forms.NumericUpDown();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblGenCount = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(15, 428);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(632, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Пуск эмуляции";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // genBeauty
            // 
            this.genBeauty.Location = new System.Drawing.Point(152, 12);
            this.genBeauty.Name = "genBeauty";
            this.genBeauty.Size = new System.Drawing.Size(495, 40);
            this.genBeauty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ген красоты";
            // 
            // lblBeautyPercent
            // 
            this.lblBeautyPercent.AutoSize = true;
            this.lblBeautyPercent.Location = new System.Drawing.Point(387, 55);
            this.lblBeautyPercent.Name = "lblBeautyPercent";
            this.lblBeautyPercent.Size = new System.Drawing.Size(32, 20);
            this.lblBeautyPercent.TabIndex = 3;
            this.lblBeautyPercent.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
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
            this.numPopulationSize.Location = new System.Drawing.Point(226, 92);
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
            this.numPopulationSize.Size = new System.Drawing.Size(140, 26);
            this.numPopulationSize.TabIndex = 5;
            this.numPopulationSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPopulationSize.ValueChanged += new System.EventHandler(this.numPopulationSize_ValueChanged);
            this.numPopulationSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.num_Scroll);
            // 
            // numPopulationSurvival
            // 
            this.numPopulationSurvival.Location = new System.Drawing.Point(226, 135);
            this.numPopulationSurvival.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPopulationSurvival.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSurvival.Name = "numPopulationSurvival";
            this.numPopulationSurvival.Size = new System.Drawing.Size(180, 26);
            this.numPopulationSurvival.TabIndex = 6;
            this.numPopulationSurvival.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numPopulationSurvival.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numPopulationSurvival_Scroll);
            // 
            // numPopulationBonusSurvival
            // 
            this.numPopulationBonusSurvival.Location = new System.Drawing.Point(226, 178);
            this.numPopulationBonusSurvival.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPopulationBonusSurvival.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numPopulationBonusSurvival.Name = "numPopulationBonusSurvival";
            this.numPopulationBonusSurvival.Size = new System.Drawing.Size(180, 26);
            this.numPopulationBonusSurvival.TabIndex = 7;
            this.numPopulationBonusSurvival.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationBonusSurvival.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numPopulationBonusSurvival_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Базовая выживаемость ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Бонусная выживаемость ";
            // 
            // numChildrenNumber
            // 
            this.numChildrenNumber.Location = new System.Drawing.Point(226, 218);
            this.numChildrenNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numChildrenNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChildrenNumber.Name = "numChildrenNumber";
            this.numChildrenNumber.Size = new System.Drawing.Size(180, 26);
            this.numChildrenNumber.TabIndex = 10;
            this.numChildrenNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numBeautyPercent
            // 
            this.numBeautyPercent.DecimalPlaces = 3;
            this.numBeautyPercent.Location = new System.Drawing.Point(194, 258);
            this.numBeautyPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBeautyPercent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numBeautyPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numBeautyPercent.Name = "numBeautyPercent";
            this.numBeautyPercent.Size = new System.Drawing.Size(96, 26);
            this.numBeautyPercent.TabIndex = 11;
            this.numBeautyPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кол-во потомков ";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(476, 55);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(110, 20);
            this.lblStep.TabIndex = 14;
            this.lblStep.Text = "Поколение: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Задержка между этапами";
            // 
            // numDelay
            // 
            this.numDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDelay.Location = new System.Drawing.Point(226, 297);
            this.numDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(180, 26);
            this.numDelay.TabIndex = 15;
            this.numDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // radGenPercent
            // 
            this.radGenPercent.AutoSize = true;
            this.radGenPercent.Checked = true;
            this.radGenPercent.Location = new System.Drawing.Point(16, 258);
            this.radGenPercent.Name = "radGenPercent";
            this.radGenPercent.Size = new System.Drawing.Size(170, 24);
            this.radGenPercent.TabIndex = 17;
            this.radGenPercent.TabStop = true;
            this.radGenPercent.Text = "% особей с геном ";
            this.radGenPercent.UseVisualStyleBackColor = true;
            this.radGenPercent.CheckedChanged += new System.EventHandler(this.radGenPercent_CheckedChanged);
            // 
            // radGenCount
            // 
            this.radGenCount.AutoSize = true;
            this.radGenCount.Location = new System.Drawing.Point(296, 258);
            this.radGenCount.Name = "radGenCount";
            this.radGenCount.Size = new System.Drawing.Size(208, 24);
            this.radGenCount.TabIndex = 18;
            this.radGenCount.Text = "Кол-во особей с геном ";
            this.radGenCount.UseVisualStyleBackColor = true;
            // 
            // numBeautyCount
            // 
            this.numBeautyCount.Enabled = false;
            this.numBeautyCount.Location = new System.Drawing.Point(512, 258);
            this.numBeautyCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBeautyCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBeautyCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeautyCount.Name = "numBeautyCount";
            this.numBeautyCount.Size = new System.Drawing.Size(136, 26);
            this.numBeautyCount.TabIndex = 19;
            this.numBeautyCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(18, 346);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(626, 72);
            this.txtLog.TabIndex = 20;
            this.txtLog.Text = "Программа готова к работе";
            // 
            // lblGenCount
            // 
            this.lblGenCount.AutoSize = true;
            this.lblGenCount.Location = new System.Drawing.Point(147, 55);
            this.lblGenCount.Name = "lblGenCount";
            this.lblGenCount.Size = new System.Drawing.Size(13, 20);
            this.lblGenCount.TabIndex = 21;
            this.lblGenCount.Text = "/";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(480, 138);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(123, 50);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "Коллекции";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 489);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblGenCount);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.numBeautyCount);
            this.Controls.Add(this.radGenCount);
            this.Controls.Add(this.radGenPercent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBeautyPercent);
            this.Controls.Add(this.numChildrenNumber);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 153816);
            this.MinimumSize = new System.Drawing.Size(672, 508);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genesis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCount)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numChildrenNumber;
        private System.Windows.Forms.NumericUpDown numBeautyPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.RadioButton radGenPercent;
        private System.Windows.Forms.RadioButton radGenCount;
        private System.Windows.Forms.NumericUpDown numBeautyCount;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblGenCount;
        private System.Windows.Forms.Button btnAbout;
    }
}

