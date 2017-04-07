namespace sh_lb2_v6
{
    partial class Sort
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
            this.listBox_sortResult = new System.Windows.Forms.ListBox();
            this.comboBox_ = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_sortResult
            // 
            this.listBox_sortResult.FormattingEnabled = true;
            this.listBox_sortResult.Location = new System.Drawing.Point(12, 48);
            this.listBox_sortResult.Name = "listBox_sortResult";
            this.listBox_sortResult.Size = new System.Drawing.Size(472, 433);
            this.listBox_sortResult.TabIndex = 0;
            // 
            // comboBox_
            // 
            this.comboBox_.FormattingEnabled = true;
            this.comboBox_.Items.AddRange(new object[] {
            "Отдел",
            "Зарплата"});
            this.comboBox_.Location = new System.Drawing.Point(12, 12);
            this.comboBox_.Name = "comboBox_";
            this.comboBox_.Size = new System.Drawing.Size(153, 21);
            this.comboBox_.TabIndex = 1;
            this.comboBox_.Text = "Параметр сортировки";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Возрастанию",
            "Убыванию"});
            this.comboBox2.Location = new System.Drawing.Point(195, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Сортировать по:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox_);
            this.Controls.Add(this.listBox_sortResult);
            this.Name = "Sort";
            this.Text = "Sort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_sortResult;
        private System.Windows.Forms.ComboBox comboBox_;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}