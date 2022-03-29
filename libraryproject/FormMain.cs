using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryproject.Model;
using Library;
using AppSecurity;
using libraryproject.AppSecurity;

namespace libraryproject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitioalTime();
        }

        private void InitioalTime()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }


        private void FormMember_Click(object sender, EventArgs e)
        {
            FormListMember l = new FormListMember();
            l.ShowDialog();
        }

        private void مدیریتکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListBook h = new FormListBook();
            h.ShowDialog();
        }

        private void امانتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListBorrow k = new FormListBorrow();
            k.ShowDialog();
        }

        private void FormMajor_Click(object sender, EventArgs e)
        {
            FormMajor g = new FormMajor();
            g.ShowDialog();
        }

        private void FormSubject_Click(object sender, EventArgs e)
        {
            FormSubject f = new FormSubject();
            f.ShowDialog();
        }

        private void تعریفمدرکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProof g = new FormProof();
            g.ShowDialog();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            FormLogin h = new FormLogin();
            h.ShowDialog();
            ShowUserInfo();
            CheckAccessMenu();
        }

        private void CheckAccessMenu()
        {
            
                menuStrip1.Items.OfType<ToolStripItem>().ToList().ForEach((p) => {
                    if (p.AccessibleDescription.Trim() != "0")
                        p.Visible = SecurityClass.CheckAuthorizeOnlineUser(Convert.ToInt32(p.AccessibleDescription)); 
                
                });
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowTime();
            ShowDate();
        }

        private void ShowDate()
        {
            LblTime.Text = DateTime.Now.ToLongDateString();
            lbldate.Text = DateTime.Now.GetPersianDetials();
        }

        private void ShowTime()
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            analogClock1.Time = DateTime.Now;
        }

        private void ShowUserInfo()
        {
            LplUser.Text = SecurityClass.UserOnline.FullName + "\n زمان ورود:" + SecurityClass.LoginTime.ToLongTimeString();
        }

        private void مدیریتکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUser().ShowDialog();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void اختصاصنقشبهکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserRole i = new FormUserRole();
            i.ShowDialog();
        }
    }
}
