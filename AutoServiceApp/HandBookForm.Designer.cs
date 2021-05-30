
namespace AutoServiceApp
{
    partial class HandBookForm
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
            this.btnTypeOfWork = new System.Windows.Forms.Button();
            this.btnSpareparts = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTypeOfWork
            // 
            this.btnTypeOfWork.Location = new System.Drawing.Point(177, 22);
            this.btnTypeOfWork.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypeOfWork.Name = "btnTypeOfWork";
            this.btnTypeOfWork.Size = new System.Drawing.Size(77, 26);
            this.btnTypeOfWork.TabIndex = 8;
            this.btnTypeOfWork.Text = "Виды работ";
            this.btnTypeOfWork.UseVisualStyleBackColor = true;
            this.btnTypeOfWork.Click += new System.EventHandler(this.btnTypeOfWork_Click);
            // 
            // btnSpareparts
            // 
            this.btnSpareparts.Location = new System.Drawing.Point(96, 22);
            this.btnSpareparts.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpareparts.Name = "btnSpareparts";
            this.btnSpareparts.Size = new System.Drawing.Size(77, 26);
            this.btnSpareparts.TabIndex = 7;
            this.btnSpareparts.Text = "Запчасти";
            this.btnSpareparts.UseVisualStyleBackColor = true;
            this.btnSpareparts.Click += new System.EventHandler(this.btnSpareparts_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(14, 22);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(77, 26);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Сотрудники";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(14, 61);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(240, 26);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Назад";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // HandBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 108);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnTypeOfWork);
            this.Controls.Add(this.btnSpareparts);
            this.Controls.Add(this.btnEmployee);
            this.Name = "HandBookForm";
            this.Text = "Справочник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTypeOfWork;
        private System.Windows.Forms.Button btnSpareparts;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button closeBtn;
    }
}