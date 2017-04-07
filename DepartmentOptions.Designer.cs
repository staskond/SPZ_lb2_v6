namespace sh_lb2_v6
{
    partial class DepartmentOptions
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
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.labelNameDepartment = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxManagerName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxMaxEmployee = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(131, 8);
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(200, 20);
            this.textBoxDepName.TabIndex = 0;
            // 
            // labelNameDepartment
            // 
            this.labelNameDepartment.AutoSize = true;
            this.labelNameDepartment.Location = new System.Drawing.Point(12, 8);
            this.labelNameDepartment.Name = "labelNameDepartment";
            this.labelNameDepartment.Size = new System.Drawing.Size(113, 13);
            this.labelNameDepartment.TabIndex = 1;
            this.labelNameDepartment.Text = "Название отделения";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(12, 38);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(80, 13);
            this.labelManager.TabIndex = 2;
            this.labelManager.Text = "Управляющий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Максимальное количество сотрудников";
            // 
            // textBoxManagerName
            // 
            this.textBoxManagerName.Location = new System.Drawing.Point(131, 38);
            this.textBoxManagerName.Name = "textBoxManagerName";
            this.textBoxManagerName.Size = new System.Drawing.Size(200, 20);
            this.textBoxManagerName.TabIndex = 4;
            // 
            // maskedTextBoxMaxEmployee
            // 
            this.maskedTextBoxMaxEmployee.Location = new System.Drawing.Point(234, 67);
            this.maskedTextBoxMaxEmployee.Mask = "000";
            this.maskedTextBoxMaxEmployee.Name = "maskedTextBoxMaxEmployee";
            this.maskedTextBoxMaxEmployee.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBoxMaxEmployee.TabIndex = 5;
            // 
            // DepartmentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 94);
            this.Controls.Add(this.maskedTextBoxMaxEmployee);
            this.Controls.Add(this.textBoxManagerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelNameDepartment);
            this.Controls.Add(this.textBoxDepName);
            this.Name = "DepartmentOptions";
            this.Text = "Отдел";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.Label labelNameDepartment;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxManagerName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMaxEmployee;
    }
}