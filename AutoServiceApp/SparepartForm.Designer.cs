namespace AutoServiceApp
{
    partial class SparepartForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdSparepart = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGurantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxGurantee = new System.Windows.Forms.TextBox();
            this.lblGuarantee = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSparepart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdSparepart);
            this.groupBox1.Location = new System.Drawing.Point(173, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(418, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запчасти";
            // 
            // dtgrdSparepart
            // 
            this.dtgrdSparepart.AllowUserToAddRows = false;
            this.dtgrdSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdSparepart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnPrice,
            this.ColumnGurantee});
            this.dtgrdSparepart.Location = new System.Drawing.Point(4, 30);
            this.dtgrdSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdSparepart.Name = "dtgrdSparepart";
            this.dtgrdSparepart.RowHeadersVisible = false;
            this.dtgrdSparepart.RowTemplate.Height = 24;
            this.dtgrdSparepart.Size = new System.Drawing.Size(409, 301);
            this.dtgrdSparepart.TabIndex = 0;
            this.dtgrdSparepart.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrdSparepart_CellMouseClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "SparepartId";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Наименование запчасти";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Price";
            this.ColumnPrice.HeaderText = "Стоимость";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnGurantee
            // 
            this.ColumnGurantee.DataPropertyName = "Guarantee";
            this.ColumnGurantee.HeaderText = "Гарантия";
            this.ColumnGurantee.Name = "ColumnGurantee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backBtn);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtbxGurantee);
            this.groupBox2.Controls.Add(this.lblGuarantee);
            this.groupBox2.Controls.Add(this.txtbxPrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.txtbxName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(9, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(160, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запчасть";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 164);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxGurantee
            // 
            this.txtbxGurantee.Location = new System.Drawing.Point(7, 122);
            this.txtbxGurantee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxGurantee.Name = "txtbxGurantee";
            this.txtbxGurantee.Size = new System.Drawing.Size(144, 20);
            this.txtbxGurantee.TabIndex = 9;
            // 
            // lblGuarantee
            // 
            this.lblGuarantee.AutoSize = true;
            this.lblGuarantee.Location = new System.Drawing.Point(4, 105);
            this.lblGuarantee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuarantee.Name = "lblGuarantee";
            this.lblGuarantee.Size = new System.Drawing.Size(54, 13);
            this.lblGuarantee.TabIndex = 8;
            this.lblGuarantee.Text = "Гарантия";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(7, 84);
            this.txtbxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(144, 20);
            this.txtbxPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(4, 67);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Стоимость, руб.";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(7, 47);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(144, 20);
            this.txtbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Наименование";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(35, 194);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SparepartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SparepartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запчасти";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSparepart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdSparepart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxGurantee;
        private System.Windows.Forms.Label lblGuarantee;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGurantee;
        private System.Windows.Forms.Button backBtn;
    }
}