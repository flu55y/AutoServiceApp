namespace AutoServiceApp
{
    partial class TypeOfWorkForm
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
            this.dtgrdTypeOfWork = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGurantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxDeadline = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxGurantee = new System.Windows.Forms.TextBox();
            this.lblGuarantee = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTypeOfWork)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdTypeOfWork);
            this.groupBox1.Location = new System.Drawing.Point(181, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(474, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виды работ";
            // 
            // dtgrdTypeOfWork
            // 
            this.dtgrdTypeOfWork.AllowUserToAddRows = false;
            this.dtgrdTypeOfWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdTypeOfWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnPrice,
            this.ColumnDeadline,
            this.ColumnGurantee});
            this.dtgrdTypeOfWork.Location = new System.Drawing.Point(4, 28);
            this.dtgrdTypeOfWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdTypeOfWork.Name = "dtgrdTypeOfWork";
            this.dtgrdTypeOfWork.RowHeadersVisible = false;
            this.dtgrdTypeOfWork.RowTemplate.Height = 24;
            this.dtgrdTypeOfWork.Size = new System.Drawing.Size(465, 291);
            this.dtgrdTypeOfWork.TabIndex = 0;
            this.dtgrdTypeOfWork.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrdTypeOfWork_CellMouseClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "TypeOfWorkId";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Вид работы";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnPrice.DataPropertyName = "Price";
            this.ColumnPrice.HeaderText = "Стоимость";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Width = 87;
            // 
            // ColumnDeadline
            // 
            this.ColumnDeadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDeadline.DataPropertyName = "Deadline";
            this.ColumnDeadline.HeaderText = "Срок выполнения";
            this.ColumnDeadline.Name = "ColumnDeadline";
            // 
            // ColumnGurantee
            // 
            this.ColumnGurantee.DataPropertyName = "Gurantee";
            this.ColumnGurantee.HeaderText = "Гарантия";
            this.ColumnGurantee.Name = "ColumnGurantee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backBtn);
            this.groupBox2.Controls.Add(this.txtbxDeadline);
            this.groupBox2.Controls.Add(this.lblDeadline);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtbxGurantee);
            this.groupBox2.Controls.Add(this.lblGuarantee);
            this.groupBox2.Controls.Add(this.txtbxPrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.txtbxName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(10, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(154, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вид работы";
            // 
            // txtbxDeadline
            // 
            this.txtbxDeadline.Location = new System.Drawing.Point(7, 120);
            this.txtbxDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxDeadline.Name = "txtbxDeadline";
            this.txtbxDeadline.Size = new System.Drawing.Size(144, 20);
            this.txtbxDeadline.TabIndex = 21;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(4, 103);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(97, 13);
            this.lblDeadline.TabIndex = 20;
            this.lblDeadline.Text = "Срок выполнения";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxGurantee
            // 
            this.txtbxGurantee.Location = new System.Drawing.Point(7, 158);
            this.txtbxGurantee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxGurantee.Name = "txtbxGurantee";
            this.txtbxGurantee.Size = new System.Drawing.Size(144, 20);
            this.txtbxGurantee.TabIndex = 22;
            // 
            // lblGuarantee
            // 
            this.lblGuarantee.AutoSize = true;
            this.lblGuarantee.Location = new System.Drawing.Point(4, 141);
            this.lblGuarantee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuarantee.Name = "lblGuarantee";
            this.lblGuarantee.Size = new System.Drawing.Size(54, 13);
            this.lblGuarantee.TabIndex = 17;
            this.lblGuarantee.Text = "Гарантия";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(7, 83);
            this.txtbxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(144, 20);
            this.txtbxPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(4, 66);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Стоимость, руб.";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(7, 46);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(144, 20);
            this.txtbxName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Наименование";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(35, 229);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TypeOfWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TypeOfWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Виды работ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTypeOfWork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdTypeOfWork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxDeadline;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbxGurantee;
        private System.Windows.Forms.Label lblGuarantee;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGurantee;
        private System.Windows.Forms.Button backBtn;
    }
}