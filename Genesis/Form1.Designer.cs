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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 287);
            this.Controls.Add(this.lblBeautyPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genBeauty);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Genesis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar genBeauty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBeautyPercent;
    }
}

