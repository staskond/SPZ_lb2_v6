using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh_lb2_v6
{
    public partial class EmployeeOptions : Form
    {
        public EmployeeOptions()
        {
            InitializeComponent();
            tbFullName.Text = StaticClassEmployee.FullName;
            tbSalary.Text = StaticClassEmployee.Salary.ToString();
            btApply.Click += (object s, EventArgs e) =>
            {
                if(tbFullName.Text.Length >= 1)
                {
                    StaticClassEmployee.FullName = tbFullName.Text;
                    StaticClassEmployee.Salary = Convert.ToDecimal(tbSalary.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Полное имя не должно быть пустым.", "Сообщение", MessageBoxButtons.OK);
                }
            };
            btCancel.Click += (object s, EventArgs e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
