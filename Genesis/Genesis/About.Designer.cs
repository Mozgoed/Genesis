namespace Genesis
{
    partial class About
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
            this.txtTasks = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteX = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnAddX = new System.Windows.Forms.Button();
            this.btnReversSort = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtAddX = new System.Windows.Forms.TextBox();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numDelete = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(8, 8);
            this.txtTasks.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasks.Multiline = true;
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(343, 127);
            this.txtTasks.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(354, 8);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить новый элемент";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteX
            // 
            this.btnDeleteX.Location = new System.Drawing.Point(8, 180);
            this.btnDeleteX.Name = "btnDeleteX";
            this.btnDeleteX.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteX.TabIndex = 12;
            this.btnDeleteX.Text = "Удалить элемент Х";
            this.btnDeleteX.UseVisualStyleBackColor = true;
            this.btnDeleteX.Click += new System.EventHandler(this.btnDeleteX_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(218, 314);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(110, 68);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Поменять порядок на обратный ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(8, 315);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 67);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Отсортировать ";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(334, 314);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(80, 67);
            this.btnDeleteAll.TabIndex = 15;
            this.btnDeleteAll.Text = "Удалить всё ";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAddX
            // 
            this.btnAddX.Location = new System.Drawing.Point(8, 220);
            this.btnAddX.Name = "btnAddX";
            this.btnAddX.Size = new System.Drawing.Size(108, 34);
            this.btnAddX.TabIndex = 16;
            this.btnAddX.Text = "Вставить элемент на место Х";
            this.btnAddX.UseVisualStyleBackColor = true;
            this.btnAddX.Click += new System.EventHandler(this.btnAddX_Click);
            // 
            // btnReversSort
            // 
            this.btnReversSort.Location = new System.Drawing.Point(108, 315);
            this.btnReversSort.Name = "btnReversSort";
            this.btnReversSort.Size = new System.Drawing.Size(104, 67);
            this.btnReversSort.TabIndex = 17;
            this.btnReversSort.Text = "Отсортировать наоборот ";
            this.btnReversSort.UseVisualStyleBackColor = true;
            this.btnReversSort.Click += new System.EventHandler(this.btnReversSort_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(8, 260);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(108, 48);
            this.btnSwap.TabIndex = 18;
            this.btnSwap.Text = "Поменять элементы местами ";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(122, 148);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(296, 20);
            this.txtAdd.TabIndex = 19;
            // 
            // txtAddX
            // 
            this.txtAddX.Location = new System.Drawing.Point(122, 224);
            this.txtAddX.Name = "txtAddX";
            this.txtAddX.Size = new System.Drawing.Size(226, 20);
            this.txtAddX.TabIndex = 21;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(354, 224);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(60, 20);
            this.numX.TabIndex = 23;
            // 
            // numDelete
            // 
            this.numDelete.Location = new System.Drawing.Point(122, 189);
            this.numDelete.Name = "numDelete";
            this.numDelete.Size = new System.Drawing.Size(60, 20);
            this.numDelete.TabIndex = 24;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(193, 276);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(60, 20);
            this.numB.TabIndex = 25;
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(122, 276);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(60, 20);
            this.numA.TabIndex = 26;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 389);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numDelete);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.txtAddX);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnReversSort);
            this.Controls.Add(this.btnAddX);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDeleteX);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTasks;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteX;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAddX;
        private System.Windows.Forms.Button btnReversSort;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtAddX;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numDelete;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numA;
    }
}