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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SecurityClass.IsAuthenticated;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim() == "" || txtUserName.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا کلمه کاربری و رمز عبور را وارد کنید");
                return;
            }
            SecurityClass.CheckAuthenticate(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
