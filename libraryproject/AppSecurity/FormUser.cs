using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSecurity
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            GridUsers.AutoGenerateColumns = false;
            GridUsers.DataSource = SecurityClass.GetUsers();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            SecurityClass.RegisterUser(txtUserFullName.Text.Trim(), txtTel.ConvertInt64(), txtMobile.ConvertInt64(), txtEmail.Text.Trim(), txtUserName.Text.Trim(), txtAddress.Text.Trim());
            MyMessagebox.ShowMessageSuccess();
        }
    }
}
