namespace AutoServiceApp
{
    partial class OrderServiceForm
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdTypeOfWork = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGurantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddTypeOfWork = new System.Windows.Forms.Button();
            this.cmbxTypeOfWork = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrdSparepart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSparepart = new System.Windows.Forms.Button();
            this.cmbbxSpareparts = new System.Windows.Forms.ComboBox();
            this.cmbxEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTypeOfWork)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNumber.Location = new System.Drawing.Point(18, 20);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(81, 17);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "№ Заказа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdTypeOfWork);
            this.groupBox1.Controls.Add(this.btnAddTypeOfWork);
            this.groupBox1.Controls.Add(this.cmbxTypeOfWork);
            this.groupBox1.Location = new System.Drawing.Point(21, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 186);
            this.groupBox1.TabIndex = 1;
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
            this.ColumnGurantee,
            this.ColumnDelete});
            this.dtgrdTypeOfWork.Location = new System.Drawing.Point(4, 46);
            this.dtgrdTypeOfWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdTypeOfWork.Name = "dtgrdTypeOfWork";
            this.dtgrdTypeOfWork.RowHeadersVisible = false;
            this.dtgrdTypeOfWork.RowTemplate.Height = 24;
            this.dtgrdTypeOfWork.Size = new System.Drawing.Size(536, 136);
            this.dtgrdTypeOfWork.TabIndex = 2;
            this.dtgrdTypeOfWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdTypeOfWork_CellContentClick);
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
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Text = "-";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddTypeOfWork
            // 
            this.btnAddTypeOfWork.Location = new System.Drawing.Point(184, 21);
            this.btnAddTypeOfWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTypeOfWork.Name = "btnAddTypeOfWork";
            this.btnAddTypeOfWork.Size = new System.Drawing.Size(70, 20);
            this.btnAddTypeOfWork.TabIndex = 1;
            this.btnAddTypeOfWork.Text = "Добавить";
            this.btnAddTypeOfWork.UseVisualStyleBackColor = true;
            this.btnAddTypeOfWork.Click += new System.EventHandler(this.btnAddTypeOfWork_Click);
            // 
            // cmbxTypeOfWork
            // 
            this.cmbxTypeOfWork.DisplayMember = "Name";
            this.cmbxTypeOfWork.FormattingEnabled = true;
            this.cmbxTypeOfWork.Location = new System.Drawing.Point(4, 21);
            this.cmbxTypeOfWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxTypeOfWork.Name = "cmbxTypeOfWork";
            this.cmbxTypeOfWork.Size = new System.Drawing.Size(176, 21);
            this.cmbxTypeOfWork.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrdSparepart);
            this.groupBox2.Controls.Add(this.btnAddSparepart);
            this.groupBox2.Controls.Add(this.cmbbxSpareparts);
            this.groupBox2.Location = new System.Drawing.Point(21, 293);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(545, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запчасти";
            // 
            // dtgrdSparepart
            // 
            this.dtgrdSparepart.AllowUserToAddRows = false;
            this.dtgrdSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdSparepart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1});
            this.dtgrdSparepart.Location = new System.Drawing.Point(4, 41);
            this.dtgrdSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdSparepart.Name = "dtgrdSparepart";
            this.dtgrdSparepart.RowHeadersVisible = false;
            this.dtgrdSparepart.RowTemplate.Height = 24;
            this.dtgrdSparepart.Size = new System.Drawing.Size(536, 154);
            this.dtgrdSparepart.TabIndex = 4;
            this.dtgrdSparepart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdSparepart_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SparepartId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование запчасти";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Guarantee";
            this.dataGridViewTextBoxColumn4.HeaderText = "Гарантия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "-";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Location = new System.Drawing.Point(184, 17);
            this.btnAddSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(70, 20);
            this.btnAddSparepart.TabIndex = 3;
            this.btnAddSparepart.Text = "Добавить";
            this.btnAddSparepart.UseVisualStyleBackColor = true;
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // cmbbxSpareparts
            // 
            this.cmbbxSpareparts.DisplayMember = "Name";
            this.cmbbxSpareparts.FormattingEnabled = true;
            this.cmbbxSpareparts.Location = new System.Drawing.Point(4, 17);
            this.cmbbxSpareparts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbbxSpareparts.Name = "cmbbxSpareparts";
            this.cmbbxSpareparts.Size = new System.Drawing.Size(176, 21);
            this.cmbbxSpareparts.TabIndex = 2;
            // 
            // cmbxEmployee
            // 
            this.cmbxEmployee.DisplayMember = "FIO";
            this.cmbxEmployee.FormattingEnabled = true;
            this.cmbxEmployee.Location = new System.Drawing.Point(26, 71);
            this.cmbxEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxEmployee.Name = "cmbxEmployee";
            this.cmbxEmployee.Size = new System.Drawing.Size(250, 21);
            this.cmbxEmployee.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(26, 52);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(60, 13);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Сотрудник";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(328, 62);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(104, 36);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Оформить заказ";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(436, 62);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 36);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // OrderServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 510);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbxEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOrderNumber);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Услуги заказа";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTypeOfWork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSparepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTypeOfWork;
        private System.Windows.Forms.ComboBox cmbxTypeOfWork;
        private System.Windows.Forms.DataGridView dtgrdTypeOfWork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSparepart;
        private System.Windows.Forms.ComboBox cmbbxSpareparts;
        private System.Windows.Forms.DataGridView dtgrdSparepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGurantee;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.ComboBox cmbxEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button backBtn;
    }
}