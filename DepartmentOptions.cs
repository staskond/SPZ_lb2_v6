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
    public partial class DepartmentOptions : Form
    {
        public DepartmentOptions()
        {
            InitializeComponent();
            
        }
        public event SendDepartament SendDepartamentEvent;
        public delegate void SendDepartament(string s, String v, string name);
        private void AddDepartment_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            
            SendDepartamentEvent(textBoxDepName.Text, maskedTextBoxMaxEmployee.Text, textBoxManagerName.Text);
        }
    }
}
