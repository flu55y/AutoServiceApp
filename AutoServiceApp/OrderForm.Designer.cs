namespace AutoServiceApp
{
    partial class OrderForm
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
            this.dtgrdOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComplete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dttmpckDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxReason = new System.Windows.Forms.RichTextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdOrders);
            this.groupBox1.Location = new System.Drawing.Point(208, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(520, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // dtgrdOrders
            // 
            this.dtgrdOrders.AllowUserToAddRows = false;
            this.dtgrdOrders.AllowUserToDeleteRows = false;
            this.dtgrdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.ColumnReason,
            this.ColumnDate,
            this.ColumnStatus,
            this.ColumnComplete});
            this.dtgrdOrders.Location = new System.Drawing.Point(4, 26);
            this.dtgrdOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrdOrders.Name = "dtgrdOrders";
            this.dtgrdOrders.RowHeadersVisible = false;
            this.dtgrdOrders.RowTemplate.Height = 24;
            this.dtgrdOrders.Size = new System.Drawing.Size(512, 294);
            this.dtgrdOrders.TabIndex = 0;
            this.dtgrdOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdOrders_CellContentClick);
            this.dtgrdOrders.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgrdOrders_RowPrePaint);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Заказ №";
            this.OrderId.Name = "OrderId";
            // 
            // ColumnReason
            // 
            this.ColumnReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnReason.DataPropertyName = "Reason";
            this.ColumnReason.HeaderText = "Причина";
            this.ColumnReason.Name = "ColumnReason";
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "Date";
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnComplete
            // 
            this.ColumnComplete.HeaderText = "";
            this.ColumnComplete.Name = "ColumnComplete";
            this.ColumnComplete.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backBtn);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.dttmpckDate);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtbxReason);
            this.groupBox2.Controls.Add(this.lblReason);
            this.groupBox2.Location = new System.Drawing.Point(10, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(194, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 158);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Дата";
            // 
            // dttmpckDate
            // 
            this.dttmpckDate.Location = new System.Drawing.Point(8, 175);
            this.dttmpckDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dttmpckDate.Name = "dttmpckDate";
            this.dttmpckDate.Size = new System.Drawing.Size(181, 20);
            this.dttmpckDate.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 217);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxReason
            // 
            this.txtbxReason.Location = new System.Drawing.Point(4, 47);
            this.txtbxReason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxReason.Name = "txtbxReason";
            this.txtbxReason.Size = new System.Drawing.Size(186, 102);
            this.txtbxReason.TabIndex = 1;
            this.txtbxReason.Text = "";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(5, 31);
            this.lblReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(50, 13);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "Причина";
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarNumber.Location = new System.Drawing.Point(9, 7);
            this.lblCarNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCarNumber.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(52, 247);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 366);
            this.Controls.Add(this.lblCarNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказы";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtbxReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dttmpckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnComplete;
        private System.Windows.Forms.Button backBtn;
    }
}