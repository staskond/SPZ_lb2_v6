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
            buttonApply.Click += new EventHandler(buttonApply_Click);
            buttonCancel.Click += new EventHandler(buttonCancel_Click);
            this.Load += new EventHandler(FormLoad);
            InitializeComponent();
            
        }
        public event SendDepartament SendDepartamentEvent;
        public delegate void SendDepartament(string s, string v, string name);
        private void AddDepartment_Load(object sender, EventArgs e)
        {
            
        }

        private void FormLoad(object sender, EventArgs e)
        {

        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
