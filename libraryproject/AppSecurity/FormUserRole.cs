using AppSecurity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryproject.AppSecurity
{
    public partial class FormUserRole : Form
    {
        public FormUserRole()
        {
            InitializeComponent();
            
        }

        private void FormUserRole_Load(object sender, EventArgs e)
        {
            ShowRoles();
            ShowUsers();
        }

        private void ShowUsers()
        {
            ComboUsers.DataSource = SecurityClass.GetUsers();
            ComboUsers.DisplayMember = "FullName";
            ComboUsers.ValueMember = "ID";
            ComboUsers.SelectedIndex = -1;
        }

        private void ShowRoles()
        {
            GridRoles.AutoGenerateColumns = false;
            GridRoles.DataSource = SecurityClass.GetRoles();
        }

        private void ComboUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int UserID = ComboUsers.GetValue();
            for (int i = 0; i < GridRoles.RowCount; i++)
            {
                int RoleID = Convert.ToInt32(GridRoles[2, i].Value);
                GridRoles[1, i].Value = SecurityClass.GetRolesOfUser(UserID,RoleID);
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if(ComboUsers.SelectedIndex == -1)
            {
                MyMessagebox.ShowMessageSelection("لطفا کاربر موردنظر را انتخاب نمایید");
                return;
            }
            int UserID = ComboUsers.GetValue();
            List<int> Rolesid = new List<int>();
            for (int i = 0; i < GridRoles.RowCount; i++)
            {
            int roleid = Convert.ToInt32(GridRoles[2, i].Value);
                if (Convert.ToBoolean(GridRoles[1, i].Value))
                    Rolesid.Add(roleid);
            }
            SecurityClass.DedicateRolesForUser(UserID, Rolesid);

        }
    }
}
