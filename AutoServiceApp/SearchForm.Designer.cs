
namespace AutoServiceApp
{
    partial class SearchForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clientsDriverLicenseCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientsDriverLicenseTextBox = new System.Windows.Forms.TextBox();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.clientsPhoneCheck = new System.Windows.Forms.CheckBox();
            this.clientsFIOCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientsPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsFIOTextBox = new System.Windows.Forms.TextBox();
            this.searchClientsBtn = new System.Windows.Forms.Button();
            this.dtgrdClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.ordersIdCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ordersIdTextBox = new System.Windows.Forms.TextBox();
            this.ordersCarNumberCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ordersCarNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchOrdersBtn = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clientsDriverLicenseCheck);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.clientsDriverLicenseTextBox);
            this.tabPage1.Controls.Add(this.backBtn1);
            this.tabPage1.Controls.Add(this.clientsPhoneCheck);
            this.tabPage1.Controls.Add(this.clientsFIOCheck);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.clientsPhoneTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.clientsFIOTextBox);
            this.tabPage1.Controls.Add(this.searchClientsBtn);
            this.tabPage1.Controls.Add(this.dtgrdClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clientsDriverLicenseCheck
            // 
            this.clientsDriverLicenseCheck.AutoSize = true;
            this.clientsDriverLicenseCheck.Location = new System.Drawing.Point(241, 68);
            this.clientsDriverLicenseCheck.Name = "clientsDriverLicenseCheck";
            this.clientsDriverLicenseCheck.Size = new System.Drawing.Size(15, 14);
            this.clientsDriverLicenseCheck.TabIndex = 18;
            this.clientsDriverLicenseCheck.UseVisualStyleBackColor = true;
            this.clientsDriverLicenseCheck.CheckedChanged += new System.EventHandler(this.clientsDriverLicenseCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Вод. удостоверение";
            // 
            // clientsDriverLicenseTextBox
            // 
            this.clientsDriverLicenseTextBox.Enabled = false;
            this.clientsDriverLicenseTextBox.Location = new System.Drawing.Point(122, 65);
            this.clientsDriverLicenseTextBox.Name = "clientsDriverLicenseTextBox";
            this.clientsDriverLicenseTextBox.Size = new System.Drawing.Size(113, 20);
            this.clientsDriverLicenseTextBox.TabIndex = 16;
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(119, 100);
            this.backBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 15;
            this.backBtn1.Text = "Назад";
            this.backBtn1.UseVisualStyleBackColor = true;
            this.backBtn1.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clientsPhoneCheck
            // 
            this.clientsPhoneCheck.AutoSize = true;
            this.clientsPhoneCheck.Location = new System.Drawing.Point(200, 42);
            this.clientsPhoneCheck.Name = "clientsPhoneCheck";
            this.clientsPhoneCheck.Size = new System.Drawing.Size(15, 14);
            this.clientsPhoneCheck.TabIndex = 10;
            this.clientsPhoneCheck.UseVisualStyleBackColor = true;
            this.clientsPhoneCheck.CheckedChanged += new System.EventHandler(this.clientsPhoneCheck_CheckedChanged);
            // 
            // clientsFIOCheck
            // 
            this.clientsFIOCheck.AutoSize = true;
            this.clientsFIOCheck.Checked = true;
            this.clientsFIOCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientsFIOCheck.Location = new System.Drawing.Point(200, 16);
            this.clientsFIOCheck.Name = "clientsFIOCheck";
            this.clientsFIOCheck.Size = new System.Drawing.Size(15, 14);
            this.clientsFIOCheck.TabIndex = 9;
            this.clientsFIOCheck.UseVisualStyleBackColor = true;
            this.clientsFIOCheck.CheckedChanged += new System.EventHandler(this.clientsFIOCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Мобильный";
            // 
            // clientsPhoneTextBox
            // 
            this.clientsPhoneTextBox.Enabled = false;
            this.clientsPhoneTextBox.Location = new System.Drawing.Point(81, 39);
            this.clientsPhoneTextBox.Name = "clientsPhoneTextBox";
            this.clientsPhoneTextBox.Size = new System.Drawing.Size(113, 20);
            this.clientsPhoneTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // clientsFIOTextBox
            // 
            this.clientsFIOTextBox.Location = new System.Drawing.Point(48, 13);
            this.clientsFIOTextBox.Name = "clientsFIOTextBox";
            this.clientsFIOTextBox.Size = new System.Drawing.Size(146, 20);
            this.clientsFIOTextBox.TabIndex = 3;
            // 
            // searchClientsBtn
            // 
            this.searchClientsBtn.Location = new System.Drawing.Point(8, 100);
            this.searchClientsBtn.Name = "searchClientsBtn";
            this.searchClientsBtn.Size = new System.Drawing.Size(106, 23);
            this.searchClientsBtn.TabIndex = 2;
            this.searchClientsBtn.Text = "Найти";
            this.searchClientsBtn.UseVisualStyleBackColor = true;
            this.searchClientsBtn.Click += new System.EventHandler(this.searchClientsBtn_Click);
            // 
            // dtgrdClients
            // 
            this.dtgrdClients.AllowUserToAddRows = false;
            this.dtgrdClients.AllowUserToDeleteRows = false;
            this.dtgrdClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Phone,
            this.DriverLicense});
            this.dtgrdClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrdClients.Location = new System.Drawing.Point(3, 128);
            this.dtgrdClients.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrdClients.Name = "dtgrdClients";
            this.dtgrdClients.RowHeadersVisible = false;
            this.dtgrdClients.RowTemplate.Height = 24;
            this.dtgrdClients.Size = new System.Drawing.Size(598, 209);
            this.dtgrdClients.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.backBtn2);
            this.tabPage2.Controls.Add(this.ordersIdCheck);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ordersIdTextBox);
            this.tabPage2.Controls.Add(this.ordersCarNumberCheck);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ordersCarNumberTextBox);
            this.tabPage2.Controls.Add(this.searchOrdersBtn);
            this.tabPage2.Controls.Add(this.ordersDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(224, 40);
            this.backBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(75, 23);
            this.backBtn2.TabIndex = 25;
            this.backBtn2.Text = "Назад";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ordersIdCheck
            // 
            this.ordersIdCheck.AutoSize = true;
            this.ordersIdCheck.Checked = true;
            this.ordersIdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ordersIdCheck.Location = new System.Drawing.Point(250, 18);
            this.ordersIdCheck.Name = "ordersIdCheck";
            this.ordersIdCheck.Size = new System.Drawing.Size(15, 14);
            this.ordersIdCheck.TabIndex = 24;
            this.ordersIdCheck.UseVisualStyleBackColor = true;
            this.ordersIdCheck.CheckedChanged += new System.EventHandler(this.ordersIdCheck_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Номер заказа";
            // 
            // ordersIdTextBox
            // 
            this.ordersIdTextBox.Location = new System.Drawing.Point(98, 15);
            this.ordersIdTextBox.Name = "ordersIdTextBox";
            this.ordersIdTextBox.Size = new System.Drawing.Size(146, 20);
            this.ordersIdTextBox.TabIndex = 22;
            // 
            // ordersCarNumberCheck
            // 
            this.ordersCarNumberCheck.AutoSize = true;
            this.ordersCarNumberCheck.Location = new System.Drawing.Point(477, 18);
            this.ordersCarNumberCheck.Name = "ordersCarNumberCheck";
            this.ordersCarNumberCheck.Size = new System.Drawing.Size(15, 14);
            this.ordersCarNumberCheck.TabIndex = 20;
            this.ordersCarNumberCheck.UseVisualStyleBackColor = true;
            this.ordersCarNumberCheck.CheckedChanged += new System.EventHandler(this.ordersCarNumberCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер авто";
            // 
            // ordersCarNumberTextBox
            // 
            this.ordersCarNumberTextBox.Enabled = false;
            this.ordersCarNumberTextBox.Location = new System.Drawing.Point(358, 15);
            this.ordersCarNumberTextBox.Name = "ordersCarNumberTextBox";
            this.ordersCarNumberTextBox.Size = new System.Drawing.Size(113, 20);
            this.ordersCarNumberTextBox.TabIndex = 15;
            // 
            // searchOrdersBtn
            // 
            this.searchOrdersBtn.Location = new System.Drawing.Point(15, 41);
            this.searchOrdersBtn.Name = "searchOrdersBtn";
            this.searchOrdersBtn.Size = new System.Drawing.Size(204, 23);
            this.searchOrdersBtn.TabIndex = 12;
            this.searchOrdersBtn.Text = "Найти";
            this.searchOrdersBtn.UseVisualStyleBackColor = true;
            this.searchOrdersBtn.Click += new System.EventHandler(this.searchOrdersBtn_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.EmployeeId,
            this.CarNumber,
            this.Reason,
            this.Status,
            this.Date,
            this.completeBtn});
            this.ordersDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 70);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.Size = new System.Drawing.Size(598, 267);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
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
            this.completeBtn.Text = "Просмотр";
            this.completeBtn.UseColumnTextForButtonValue = true;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Мобильный";
            this.Phone.Name = "Phone";
            // 
            // DriverLicense
            // 
            this.DriverLicense.DataPropertyName = "DriverLicense";
            this.DriverLicense.HeaderText = "Вод. удостоверение";
            this.DriverLicense.Name = "DriverLicense";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 366);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgrdClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientsPhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientsFIOTextBox;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.CheckBox clientsPhoneCheck;
        private System.Windows.Forms.CheckBox clientsFIOCheck;
        protected System.Windows.Forms.Button searchClientsBtn;
        private System.Windows.Forms.CheckBox ordersCarNumberCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ordersCarNumberTextBox;
        protected System.Windows.Forms.Button searchOrdersBtn;
        private System.Windows.Forms.CheckBox ordersIdCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ordersIdTextBox;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn completeBtn;
        private System.Windows.Forms.CheckBox clientsDriverLicenseCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientsDriverLicenseTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverLicense;
    }
}