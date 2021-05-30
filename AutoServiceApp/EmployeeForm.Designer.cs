namespace AutoServiceApp
{
    partial class EmployeeForm
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
            this.dtgrdEmployee = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbxSpeciality = new System.Windows.Forms.ComboBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.txtbxFIO = new System.Windows.Forms.TextBox();
            this.lblFio = new System.Windows.Forms.Label();
            this.btnSpeciality = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdEmployee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdEmployee);
            this.groupBox1.Location = new System.Drawing.Point(194, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(398, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // dtgrdEmployee
            // 
            this.dtgrdEmployee.AllowUserToAddRows = false;
            this.dtgrdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnFio,
            this.ColumnSpeciality});
            this.dtgrdEmployee.Location = new System.Drawing.Point(4, 28);
            this.dtgrdEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdEmployee.Name = "dtgrdEmployee";
            this.dtgrdEmployee.RowHeadersVisible = false;
            this.dtgrdEmployee.RowTemplate.Height = 24;
            this.dtgrdEmployee.Size = new System.Drawing.Size(388, 287);
            this.dtgrdEmployee.TabIndex = 0;
            this.dtgrdEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrdEmployee_CellMouseClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "EmployeeId";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnFio
            // 
            this.ColumnFio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFio.DataPropertyName = "FIO";
            this.ColumnFio.HeaderText = "ФИО";
            this.ColumnFio.Name = "ColumnFio";
            // 
            // ColumnSpeciality
            // 
            this.ColumnSpeciality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSpeciality.DataPropertyName = "Speciality";
            this.ColumnSpeciality.HeaderText = "Специальность";
            this.ColumnSpeciality.Name = "ColumnSpeciality";
            this.ColumnSpeciality.Width = 110;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backBtn);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.cmbxSpeciality);
            this.groupBox2.Controls.Add(this.lblSpeciality);
            this.groupBox2.Controls.Add(this.txtbxFIO);
            this.groupBox2.Controls.Add(this.lblFio);
            this.groupBox2.Location = new System.Drawing.Point(10, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(179, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудник";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbxSpeciality
            // 
            this.cmbxSpeciality.DisplayMember = "Name";
            this.cmbxSpeciality.FormattingEnabled = true;
            this.cmbxSpeciality.Location = new System.Drawing.Point(7, 81);
            this.cmbxSpeciality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxSpeciality.Name = "cmbxSpeciality";
            this.cmbxSpeciality.Size = new System.Drawing.Size(166, 21);
            this.cmbxSpeciality.TabIndex = 5;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Location = new System.Drawing.Point(4, 65);
            this.lblSpeciality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(85, 13);
            this.lblSpeciality.TabIndex = 4;
            this.lblSpeciality.Text = "Специальность";
            // 
            // txtbxFIO
            // 
            this.txtbxFIO.Location = new System.Drawing.Point(7, 45);
            this.txtbxFIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxFIO.Name = "txtbxFIO";
            this.txtbxFIO.Size = new System.Drawing.Size(166, 20);
            this.txtbxFIO.TabIndex = 3;
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(4, 28);
            this.lblFio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 2;
            this.lblFio.Text = "ФИО";
            // 
            // btnSpeciality
            // 
            this.btnSpeciality.Location = new System.Drawing.Point(10, 10);
            this.btnSpeciality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpeciality.Name = "btnSpeciality";
            this.btnSpeciality.Size = new System.Drawing.Size(94, 22);
            this.btnSpeciality.TabIndex = 2;
            this.btnSpeciality.Text = "Специальности";
            this.btnSpeciality.UseVisualStyleBackColor = true;
            this.btnSpeciality.Click += new System.EventHandler(this.btnSpeciality_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(44, 149);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSpeciality);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdEmployee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbxSpeciality;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.TextBox txtbxFIO;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpeciality;
        private System.Windows.Forms.Button backBtn;
    }
}