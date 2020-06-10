using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH.Demo.VCPMC_Report.common;

namespace TH.Demo.VCPMC_Report
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Core.IsLogin = false;
            Core.User = "";
            Core.Password = "";
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Trim() == "Admin" && txtPassword.Text.Trim() == "123")
            {
                Core.IsLogin = true;
                Core.User = "Admin";
                Core.Password = "123";
                this.Close();
            }
            else
            {
                Core.IsLogin = false;
                Core.User = "";
                Core.Password = "";
                MessageBox.Show("Infomation of login is wrong, please check info agin!");
            }
        }
    }
}
