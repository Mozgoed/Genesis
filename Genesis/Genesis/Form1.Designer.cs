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
            this.numPopulationSizeM = new System.Windows.Forms.NumericUpDown();
            this.numPopulationSurvival = new System.Windows.Forms.NumericUpDown();
            this.numPopulationBonusSurvival = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numChildrenNumber = new System.Windows.Forms.NumericUpDown();
            this.numBeautyPercentM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.radGenPercent = new System.Windows.Forms.RadioButton();
            this.radGenCount = new System.Windows.Forms.RadioButton();
            this.numBeautyCountM = new System.Windows.Forms.NumericUpDown();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblGenCount = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.numPopulationSizeF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl2Parents = new System.Windows.Forms.Label();
            this.num2ParentsChance = new System.Windows.Forms.NumericUpDown();
            this.num1ParentChance = new System.Windows.Forms.NumericUpDown();
            this.lbl1Parent = new System.Windows.Forms.Label();
            this.numBeautyCountF = new System.Windows.Forms.NumericUpDown();
            this.numBeautyPercentF = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSizeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercentM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCountM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSizeF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2ParentsChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1ParentChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCountF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercentF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(10, 351);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
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
            this.genBeauty.Margin = new System.Windows.Forms.Padding(2);
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
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер популяции        М:";
            // 
            // numPopulationSizeM
            // 
            this.numPopulationSizeM.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPopulationSizeM.Location = new System.Drawing.Point(151, 58);
            this.numPopulationSizeM.Margin = new System.Windows.Forms.Padding(2);
            this.numPopulationSizeM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopulationSizeM.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSizeM.Name = "numPopulationSizeM";
            this.numPopulationSizeM.Size = new System.Drawing.Size(93, 20);
            this.numPopulationSizeM.TabIndex = 5;
            this.numPopulationSizeM.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPopulationSizeM.ValueChanged += new System.EventHandler(this.numPopulationSize_ValueChanged);
            this.numPopulationSizeM.Scroll += new System.Windows.Forms.ScrollEventHandler(this.num_Scroll);
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
            80,
            0,
            0,
            0});
            // 
            // numPopulationBonusSurvival
            // 
            this.numPopulationBonusSurvival.Location = new System.Drawing.Point(151, 116);
            this.numPopulationBonusSurvival.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numPopulationBonusSurvival.Name = "numPopulationBonusSurvival";
            this.numPopulationBonusSurvival.Size = new System.Drawing.Size(120, 20);
            this.numPopulationBonusSurvival.TabIndex = 7;
            this.numPopulationBonusSurvival.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Базовая выживаемость ";
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
            // numChildrenNumber
            // 
            this.numChildrenNumber.Location = new System.Drawing.Point(151, 142);
            this.numChildrenNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChildrenNumber.Name = "numChildrenNumber";
            this.numChildrenNumber.Size = new System.Drawing.Size(120, 20);
            this.numChildrenNumber.TabIndex = 10;
            this.numChildrenNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numBeautyPercentM
            // 
            this.numBeautyPercentM.DecimalPlaces = 3;
            this.numBeautyPercentM.Location = new System.Drawing.Point(34, 246);
            this.numBeautyPercentM.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numBeautyPercentM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numBeautyPercentM.Name = "numBeautyPercentM";
            this.numBeautyPercentM.Size = new System.Drawing.Size(64, 20);
            this.numBeautyPercentM.TabIndex = 11;
            this.numBeautyPercentM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(317, 36);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(75, 13);
            this.lblStep.TabIndex = 14;
            this.lblStep.Text = "Поколение: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
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
            this.numDelay.Location = new System.Drawing.Point(159, 272);
            this.numDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(120, 20);
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
            this.radGenPercent.Location = new System.Drawing.Point(11, 224);
            this.radGenPercent.Margin = new System.Windows.Forms.Padding(2);
            this.radGenPercent.Name = "radGenPercent";
            this.radGenPercent.Size = new System.Drawing.Size(118, 17);
            this.radGenPercent.TabIndex = 17;
            this.radGenPercent.TabStop = true;
            this.radGenPercent.Text = "% особей с геном ";
            this.radGenPercent.UseVisualStyleBackColor = true;
            this.radGenPercent.CheckedChanged += new System.EventHandler(this.radGenPercent_CheckedChanged);
            // 
            // radGenCount
            // 
            this.radGenCount.AutoSize = true;
            this.radGenCount.Location = new System.Drawing.Point(200, 224);
            this.radGenCount.Margin = new System.Windows.Forms.Padding(2);
            this.radGenCount.Name = "radGenCount";
            this.radGenCount.Size = new System.Drawing.Size(144, 17);
            this.radGenCount.TabIndex = 18;
            this.radGenCount.Text = "Кол-во особей с геном ";
            this.radGenCount.UseVisualStyleBackColor = true;
            // 
            // numBeautyCountM
            // 
            this.numBeautyCountM.Enabled = false;
            this.numBeautyCountM.Location = new System.Drawing.Point(223, 246);
            this.numBeautyCountM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBeautyCountM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeautyCountM.Name = "numBeautyCountM";
            this.numBeautyCountM.Size = new System.Drawing.Size(91, 20);
            this.numBeautyCountM.TabIndex = 19;
            this.numBeautyCountM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(10, 298);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(421, 48);
            this.txtLog.TabIndex = 20;
            this.txtLog.Text = "Программа готова к работе";
            // 
            // lblGenCount
            // 
            this.lblGenCount.AutoSize = true;
            this.lblGenCount.Location = new System.Drawing.Point(98, 36);
            this.lblGenCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenCount.Name = "lblGenCount";
            this.lblGenCount.Size = new System.Drawing.Size(0, 13);
            this.lblGenCount.TabIndex = 21;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(320, 90);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(82, 32);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "Коллекции";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(11, 33);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(47, 19);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // numPopulationSizeF
            // 
            this.numPopulationSizeF.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPopulationSizeF.Location = new System.Drawing.Point(309, 58);
            this.numPopulationSizeF.Margin = new System.Windows.Forms.Padding(2);
            this.numPopulationSizeF.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopulationSizeF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSizeF.Name = "numPopulationSizeF";
            this.numPopulationSizeF.Size = new System.Drawing.Size(93, 20);
            this.numPopulationSizeF.TabIndex = 24;
            this.numPopulationSizeF.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ж:";
            // 
            // lbl2Parents
            // 
            this.lbl2Parents.AutoSize = true;
            this.lbl2Parents.Location = new System.Drawing.Point(7, 172);
            this.lbl2Parents.Name = "lbl2Parents";
            this.lbl2Parents.Size = new System.Drawing.Size(260, 13);
            this.lbl2Parents.TabIndex = 26;
            this.lbl2Parents.Text = "Шанс передачи потомку , когда ген у 2 родителей";
            // 
            // num2ParentsChance
            // 
            this.num2ParentsChance.DecimalPlaces = 3;
            this.num2ParentsChance.Location = new System.Drawing.Point(282, 170);
            this.num2ParentsChance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num2ParentsChance.Name = "num2ParentsChance";
            this.num2ParentsChance.Size = new System.Drawing.Size(120, 20);
            this.num2ParentsChance.TabIndex = 27;
            this.num2ParentsChance.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // num1ParentChance
            // 
            this.num1ParentChance.DecimalPlaces = 3;
            this.num1ParentChance.Location = new System.Drawing.Point(282, 198);
            this.num1ParentChance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num1ParentChance.Name = "num1ParentChance";
            this.num1ParentChance.Size = new System.Drawing.Size(120, 20);
            this.num1ParentChance.TabIndex = 29;
            this.num1ParentChance.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbl1Parent
            // 
            this.lbl1Parent.AutoSize = true;
            this.lbl1Parent.Location = new System.Drawing.Point(7, 200);
            this.lbl1Parent.Name = "lbl1Parent";
            this.lbl1Parent.Size = new System.Drawing.Size(254, 13);
            this.lbl1Parent.TabIndex = 28;
            this.lbl1Parent.Text = "Шанс передачи потомку , когда ген у 1 родителя";
            // 
            // numBeautyCountF
            // 
            this.numBeautyCountF.Enabled = false;
            this.numBeautyCountF.Location = new System.Drawing.Point(341, 246);
            this.numBeautyCountF.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBeautyCountF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeautyCountF.Name = "numBeautyCountF";
            this.numBeautyCountF.Size = new System.Drawing.Size(91, 20);
            this.numBeautyCountF.TabIndex = 30;
            this.numBeautyCountF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBeautyPercentF
            // 
            this.numBeautyPercentF.DecimalPlaces = 3;
            this.numBeautyPercentF.Location = new System.Drawing.Point(129, 246);
            this.numBeautyPercentF.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numBeautyPercentF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numBeautyPercentF.Name = "numBeautyPercentF";
            this.numBeautyPercentF.Size = new System.Drawing.Size(64, 20);
            this.numBeautyPercentF.TabIndex = 31;
            this.numBeautyPercentF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "М:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ж:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "М:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Ж:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 391);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numBeautyPercentF);
            this.Controls.Add(this.numBeautyCountF);
            this.Controls.Add(this.num1ParentChance);
            this.Controls.Add(this.lbl1Parent);
            this.Controls.Add(this.num2ParentsChance);
            this.Controls.Add(this.lbl2Parents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPopulationSizeF);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblGenCount);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.numBeautyCountM);
            this.Controls.Add(this.radGenCount);
            this.Controls.Add(this.radGenPercent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBeautyPercentM);
            this.Controls.Add(this.numChildrenNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPopulationBonusSurvival);
            this.Controls.Add(this.numPopulationSurvival);
            this.Controls.Add(this.numPopulationSizeM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBeautyPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genBeauty);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 99994);
            this.MinimumSize = new System.Drawing.Size(453, 430);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genesis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSizeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationBonusSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercentM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCountM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSizeF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2ParentsChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1ParentChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyCountF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeautyPercentF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar genBeauty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBeautyPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPopulationSizeM;
        private System.Windows.Forms.NumericUpDown numPopulationSurvival;
        private System.Windows.Forms.NumericUpDown numPopulationBonusSurvival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numChildrenNumber;
        private System.Windows.Forms.NumericUpDown numBeautyPercentM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.RadioButton radGenPercent;
        private System.Windows.Forms.RadioButton radGenCount;
        private System.Windows.Forms.NumericUpDown numBeautyCountM;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblGenCount;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.NumericUpDown numPopulationSizeF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl2Parents;
        private System.Windows.Forms.NumericUpDown num2ParentsChance;
        private System.Windows.Forms.NumericUpDown num1ParentChance;
        private System.Windows.Forms.Label lbl1Parent;
        private System.Windows.Forms.NumericUpDown numBeautyCountF;
        private System.Windows.Forms.NumericUpDown numBeautyPercentF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

