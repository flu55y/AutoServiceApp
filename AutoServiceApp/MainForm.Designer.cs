namespace AutoServiceApp
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdClients = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrders = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbxCarNumber = new System.Windows.Forms.TextBox();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.txtbxCarMark = new System.Windows.Forms.TextBox();
            this.lblCarMark = new System.Windows.Forms.Label();
            this.txtbxDriverLicense = new System.Windows.Forms.TextBox();
            this.lblDriverLicense = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbxFIO = new System.Windows.Forms.TextBox();
            this.lblFio = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.readyOrdersBtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.handBookBtn = new System.Windows.Forms.Button();
            this.ownerIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdClients);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(220, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(658, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // dtgrdClients
            // 
            this.dtgrdClients.AllowUserToAddRows = false;
            this.dtgrdClients.AllowUserToDeleteRows = false;
            this.dtgrdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnFio,
            this.ColumnPhone,
            this.ColumnDriverLicense,
            this.ColumnCarMark,
            this.ColumnCarNumber,
            this.ColumnOrders});
            this.dtgrdClients.Location = new System.Drawing.Point(4, 27);
            this.dtgrdClients.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrdClients.Name = "dtgrdClients";
            this.dtgrdClients.RowHeadersVisible = false;
            this.dtgrdClients.RowTemplate.Height = 24;
            this.dtgrdClients.Size = new System.Drawing.Size(649, 154);
            this.dtgrdClients.TabIndex = 0;
            this.dtgrdClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdClients_CellContentClick);
            this.dtgrdClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrdClients_CellMouseClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "OwnerId";
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
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.Name = "ColumnPhone";
            // 
            // ColumnDriverLicense
            // 
            this.ColumnDriverLicense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnDriverLicense.DataPropertyName = "DriverLicense";
            this.ColumnDriverLicense.HeaderText = "Вод. удостоверение";
            this.ColumnDriverLicense.Name = "ColumnDriverLicense";
            this.ColumnDriverLicense.Width = 122;
            // 
            // ColumnCarMark
            // 
            this.ColumnCarMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnCarMark.DataPropertyName = "CarMark";
            this.ColumnCarMark.HeaderText = "Марка машины";
            this.ColumnCarMark.Name = "ColumnCarMark";
            this.ColumnCarMark.Width = 101;
            // 
            // ColumnCarNumber
            // 
            this.ColumnCarNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnCarNumber.DataPropertyName = "CarNumber";
            this.ColumnCarNumber.HeaderText = "Номер машины";
            this.ColumnCarNumber.Name = "ColumnCarNumber";
            this.ColumnCarNumber.Width = 102;
            // 
            // ColumnOrders
            // 
            this.ColumnOrders.HeaderText = "";
            this.ColumnOrders.Name = "ColumnOrders";
            this.ColumnOrders.Text = "Заказы";
            this.ColumnOrders.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ownerIdLabel);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Controls.Add(this.ownerNameLabel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtbxCarNumber);
            this.groupBox2.Controls.Add(this.lblCarNumber);
            this.groupBox2.Controls.Add(this.txtbxCarMark);
            this.groupBox2.Controls.Add(this.lblCarMark);
            this.groupBox2.Controls.Add(this.txtbxDriverLicense);
            this.groupBox2.Controls.Add(this.lblDriverLicense);
            this.groupBox2.Controls.Add(this.txtbxPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.txtbxFIO);
            this.groupBox2.Controls.Add(this.lblFio);
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(206, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(36, 317);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 26);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(13, 263);
            this.ownerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(81, 13);
            this.ownerNameLabel.TabIndex = 11;
            this.ownerNameLabel.Text = "ФИО клиента:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 212);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxCarNumber
            // 
            this.txtbxCarNumber.Location = new System.Drawing.Point(15, 189);
            this.txtbxCarNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxCarNumber.Name = "txtbxCarNumber";
            this.txtbxCarNumber.Size = new System.Drawing.Size(166, 20);
            this.txtbxCarNumber.TabIndex = 9;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Location = new System.Drawing.Point(13, 172);
            this.lblCarNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(105, 13);
            this.lblCarNumber.TabIndex = 8;
            this.lblCarNumber.Text = "Номер автомобиля";
            // 
            // txtbxCarMark
            // 
            this.txtbxCarMark.Location = new System.Drawing.Point(15, 152);
            this.txtbxCarMark.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxCarMark.Name = "txtbxCarMark";
            this.txtbxCarMark.Size = new System.Drawing.Size(166, 20);
            this.txtbxCarMark.TabIndex = 7;
            // 
            // lblCarMark
            // 
            this.lblCarMark.AutoSize = true;
            this.lblCarMark.Location = new System.Drawing.Point(13, 135);
            this.lblCarMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMark.Name = "lblCarMark";
            this.lblCarMark.Size = new System.Drawing.Size(104, 13);
            this.lblCarMark.TabIndex = 6;
            this.lblCarMark.Text = "Марка автомобиля";
            // 
            // txtbxDriverLicense
            // 
            this.txtbxDriverLicense.Location = new System.Drawing.Point(15, 115);
            this.txtbxDriverLicense.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxDriverLicense.Name = "txtbxDriverLicense";
            this.txtbxDriverLicense.Size = new System.Drawing.Size(166, 20);
            this.txtbxDriverLicense.TabIndex = 5;
            // 
            // lblDriverLicense
            // 
            this.lblDriverLicense.AutoSize = true;
            this.lblDriverLicense.Location = new System.Drawing.Point(13, 98);
            this.lblDriverLicense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverLicense.Name = "lblDriverLicense";
            this.lblDriverLicense.Size = new System.Drawing.Size(108, 13);
            this.lblDriverLicense.TabIndex = 4;
            this.lblDriverLicense.Text = "Вод. удостоверение";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(15, 77);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(166, 20);
            this.txtbxPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(13, 60);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Телефон";
            // 
            // txtbxFIO
            // 
            this.txtbxFIO.Location = new System.Drawing.Point(15, 40);
            this.txtbxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxFIO.Name = "txtbxFIO";
            this.txtbxFIO.Size = new System.Drawing.Size(166, 20);
            this.txtbxFIO.TabIndex = 1;
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(13, 23);
            this.lblFio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 0;
            this.lblFio.Text = "ФИО";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OrdersDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(220, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 184);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Активные заказы";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.EmployeeId,
            this.CarNumber,
            this.Reason,
            this.Status,
            this.Date,
            this.completeBtn});
            this.OrdersDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrdersDataGridView.Location = new System.Drawing.Point(6, 19);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.RowHeadersVisible = false;
            this.OrdersDataGridView.Size = new System.Drawing.Size(646, 150);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentClick);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Заказ №";
            this.OrderId.Name = "OrderId";
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Сотрудник";
            this.EmployeeId.Name = "EmployeeId";
            // 
            // CarNumber
            // 
            this.CarNumber.DataPropertyName = "CarNumber";
            this.CarNumber.HeaderText = "Номер авто";
            this.CarNumber.Name = "CarNumber";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Причина";
            this.Reason.Name = "Reason";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // completeBtn
            // 
            this.completeBtn.HeaderText = "";
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Text = "Оформить";
            this.completeBtn.UseColumnTextForButtonValue = true;
            // 
            // readyOrdersBtn
            // 
            this.readyOrdersBtn.Location = new System.Drawing.Point(140, 10);
            this.readyOrdersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.readyOrdersBtn.Name = "readyOrdersBtn";
            this.readyOrdersBtn.Size = new System.Drawing.Size(120, 26);
            this.readyOrdersBtn.TabIndex = 7;
            this.readyOrdersBtn.Text = "Готовые заказы";
            this.readyOrdersBtn.UseVisualStyleBackColor = true;
            this.readyOrdersBtn.Click += new System.EventHandler(this.readyOrdersBtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(772, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // handBookBtn
            // 
            this.handBookBtn.Location = new System.Drawing.Point(16, 10);
            this.handBookBtn.Margin = new System.Windows.Forms.Padding(2);
            this.handBookBtn.Name = "handBookBtn";
            this.handBookBtn.Size = new System.Drawing.Size(120, 26);
            this.handBookBtn.TabIndex = 8;
            this.handBookBtn.Text = "Справочник";
            this.handBookBtn.UseVisualStyleBackColor = true;
            this.handBookBtn.Click += new System.EventHandler(this.handBookBtn_Click);
            // 
            // ownerIdLabel
            // 
            this.ownerIdLabel.AutoSize = true;
            this.ownerIdLabel.Location = new System.Drawing.Point(13, 287);
            this.ownerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ownerIdLabel.Name = "ownerIdLabel";
            this.ownerIdLabel.Size = new System.Drawing.Size(63, 13);
            this.ownerIdLabel.TabIndex = 13;
            this.ownerIdLabel.Text = "Id клиента:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 451);
            this.Controls.Add(this.handBookBtn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.readyOrdersBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Автосервис";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxCarNumber;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.TextBox txtbxCarMark;
        private System.Windows.Forms.Label lblCarMark;
        private System.Windows.Forms.TextBox txtbxDriverLicense;
        private System.Windows.Forms.Label lblDriverLicense;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtbxFIO;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriverLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarNumber;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOrders;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Button readyOrdersBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn completeBtn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button handBookBtn;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label ownerIdLabel;
    }
}

