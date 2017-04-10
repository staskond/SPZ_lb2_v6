namespace sh_lb2_v6
{
    partial class s
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
            this.components = new System.ComponentModel.Container();
            this.listBoxDep = new System.Windows.Forms.ListBox();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.buttonDelDep = new System.Windows.Forms.Button();
            this.buttonChangeDep = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonDelEmployee = new System.Windows.Forms.Button();
            this.buttonChangeEmployee = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.buttonSortEmployees = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDep
            // 
            this.listBoxDep.FormattingEnabled = true;
            this.listBoxDep.Location = new System.Drawing.Point(22, 34);
            this.listBoxDep.Name = "listBoxDep";
            this.listBoxDep.Size = new System.Drawing.Size(159, 316);
            this.listBoxDep.TabIndex = 0;
            this.listBoxDep.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.Location = new System.Drawing.Point(217, 34);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(166, 316);
            this.listBoxEmployee.TabIndex = 1;
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.Location = new System.Drawing.Point(22, 356);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(159, 23);
            this.buttonAddDep.TabIndex = 2;
            this.buttonAddDep.Text = "Добавить отдел";
            this.buttonAddDep.UseVisualStyleBackColor = true;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // buttonDelDep
            // 
            this.buttonDelDep.Location = new System.Drawing.Point(22, 385);
            this.buttonDelDep.Name = "buttonDelDep";
            this.buttonDelDep.Size = new System.Drawing.Size(159, 23);
            this.buttonDelDep.TabIndex = 3;
            this.buttonDelDep.Text = "Удалить отдел";
            this.buttonDelDep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelDep.UseVisualStyleBackColor = true;
            this.buttonDelDep.Click += new System.EventHandler(this.buttonDelDep_Click);
            // 
            // buttonChangeDep
            // 
            this.buttonChangeDep.Location = new System.Drawing.Point(22, 414);
            this.buttonChangeDep.Name = "buttonChangeDep";
            this.buttonChangeDep.Size = new System.Drawing.Size(159, 23);
            this.buttonChangeDep.TabIndex = 4;
            this.buttonChangeDep.Text = "Изменить отдел";
            this.buttonChangeDep.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(217, 356);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(166, 23);
            this.buttonAddEmployee.TabIndex = 5;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDelEmployee
            // 
            this.buttonDelEmployee.Location = new System.Drawing.Point(217, 385);
            this.buttonDelEmployee.Name = "buttonDelEmployee";
            this.buttonDelEmployee.Size = new System.Drawing.Size(166, 23);
            this.buttonDelEmployee.TabIndex = 6;
            this.buttonDelEmployee.Text = "Удалить сотрудника";
            this.buttonDelEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(217, 414);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(166, 23);
            this.buttonChangeEmployee.TabIndex = 7;
            this.buttonChangeEmployee.Text = "Изменить сотруднику";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonSortEmployees
            // 
            this.buttonSortEmployees.Location = new System.Drawing.Point(217, 444);
            this.buttonSortEmployees.Name = "buttonSortEmployees";
            this.buttonSortEmployees.Size = new System.Drawing.Size(166, 23);
            this.buttonSortEmployees.TabIndex = 8;
            this.buttonSortEmployees.TabStop = false;
            this.buttonSortEmployees.Text = "Сортировать сотрудников";
            this.buttonSortEmployees.UseVisualStyleBackColor = true;
            this.buttonSortEmployees.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(sh_lb2_v6.Department);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(sh_lb2_v6.Department);
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 482);
            this.Controls.Add(this.buttonSortEmployees);
            this.Controls.Add(this.buttonChangeEmployee);
            this.Controls.Add(this.buttonDelEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonChangeDep);
            this.Controls.Add(this.buttonDelDep);
            this.Controls.Add(this.buttonAddDep);
            this.Controls.Add(this.listBoxEmployee);
            this.Controls.Add(this.listBoxDep);
            this.Name = "s";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.s_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDep;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Button buttonAddDep;
        private System.Windows.Forms.Button buttonDelDep;
        private System.Windows.Forms.Button buttonChangeDep;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDelEmployee;
        private System.Windows.Forms.Button buttonChangeEmployee;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button buttonSortEmployees;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
    }
}

