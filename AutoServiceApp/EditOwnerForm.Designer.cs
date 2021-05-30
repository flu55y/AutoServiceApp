
namespace AutoServiceApp
{
    partial class EditOwnerForm
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
            this.editBtn = new System.Windows.Forms.Button();
            this.txtbxCarMark = new System.Windows.Forms.TextBox();
            this.lblCarMark = new System.Windows.Forms.Label();
            this.txtbxDriverLicense = new System.Windows.Forms.TextBox();
            this.lblDriverLicense = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbxFIO = new System.Windows.Forms.TextBox();
            this.lblFio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(102, 249);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 32);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Сохранить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // txtbxCarMark
            // 
            this.txtbxCarMark.Location = new System.Drawing.Point(15, 205);
            this.txtbxCarMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxCarMark.Name = "txtbxCarMark";
            this.txtbxCarMark.Size = new System.Drawing.Size(275, 22);
            this.txtbxCarMark.TabIndex = 18;
            // 
            // lblCarMark
            // 
            this.lblCarMark.AutoSize = true;
            this.lblCarMark.Location = new System.Drawing.Point(12, 186);
            this.lblCarMark.Name = "lblCarMark";
            this.lblCarMark.Size = new System.Drawing.Size(133, 17);
            this.lblCarMark.TabIndex = 17;
            this.lblCarMark.Text = "Марка автомобиля";
            // 
            // txtbxDriverLicense
            // 
            this.txtbxDriverLicense.Location = new System.Drawing.Point(15, 153);
            this.txtbxDriverLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxDriverLicense.Name = "txtbxDriverLicense";
            this.txtbxDriverLicense.Size = new System.Drawing.Size(275, 22);
            this.txtbxDriverLicense.TabIndex = 16;
            // 
            // lblDriverLicense
            // 
            this.lblDriverLicense.AutoSize = true;
            this.lblDriverLicense.Location = new System.Drawing.Point(12, 134);
            this.lblDriverLicense.Name = "lblDriverLicense";
            this.lblDriverLicense.Size = new System.Drawing.Size(141, 17);
            this.lblDriverLicense.TabIndex = 15;
            this.lblDriverLicense.Text = "Вод. удостоверение";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(15, 99);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(275, 22);
            this.txtbxPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Телефон";
            // 
            // txtbxFIO
            // 
            this.txtbxFIO.Location = new System.Drawing.Point(15, 45);
            this.txtbxFIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxFIO.Name = "txtbxFIO";
            this.txtbxFIO.Size = new System.Drawing.Size(275, 22);
            this.txtbxFIO.TabIndex = 12;
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(12, 26);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(42, 17);
            this.lblFio.TabIndex = 11;
            this.lblFio.Text = "ФИО";
            // 
            // EditOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 367);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.txtbxCarMark);
            this.Controls.Add(this.lblCarMark);
            this.Controls.Add(this.txtbxDriverLicense);
            this.Controls.Add(this.lblDriverLicense);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbxFIO);
            this.Controls.Add(this.lblFio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditOwnerForm";
            this.Text = "Редактировать пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox txtbxCarMark;
        private System.Windows.Forms.Label lblCarMark;
        private System.Windows.Forms.TextBox txtbxDriverLicense;
        private System.Windows.Forms.Label lblDriverLicense;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtbxFIO;
        private System.Windows.Forms.Label lblFio;
    }
}