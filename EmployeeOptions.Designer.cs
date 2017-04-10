namespace sh_lb2_v6
{
    partial class EmployeeOptions
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
            this.maskedTextBox1_empname = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_salary = new System.Windows.Forms.TextBox();
            this.comboBox1_changedep = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1_empname
            // 
            this.maskedTextBox1_empname.Location = new System.Drawing.Point(144, 45);
            this.maskedTextBox1_empname.Mask = "L.L.L???????????????";
            this.maskedTextBox1_empname.Name = "maskedTextBox1_empname";
            this.maskedTextBox1_empname.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1_empname.TabIndex = 0;
            this.maskedTextBox1_empname.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ф.И.О.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зарплата";
            // 
            // textBox1_salary
            // 
            this.textBox1_salary.Location = new System.Drawing.Point(144, 127);
            this.textBox1_salary.Name = "textBox1_salary";
            this.textBox1_salary.Size = new System.Drawing.Size(121, 20);
            this.textBox1_salary.TabIndex = 6;
            // 
            // comboBox1_changedep
            // 
            this.comboBox1_changedep.FormattingEnabled = true;
            this.comboBox1_changedep.Location = new System.Drawing.Point(144, 86);
            this.comboBox1_changedep.Name = "comboBox1_changedep";
            this.comboBox1_changedep.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_changedep.TabIndex = 10;
            this.comboBox1_changedep.Text = "Выберите отдел";
            this.comboBox1_changedep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(189, 180);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(108, 180);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 12;
            this.btApply.Text = "Применить";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // EmployeeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 215);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.comboBox1_changedep);
            this.Controls.Add(this.textBox1_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1_empname);
            this.Name = "EmployeeOptions";
            this.Text = "EmployeeOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1_empname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_salary;
        private System.Windows.Forms.ComboBox comboBox1_changedep;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
    }
}