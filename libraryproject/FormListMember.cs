
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

namespace libraryproject
{
    public partial class FormListMember : Form
    {
        Member SelectedMember = null;
        public FormListMember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMember m = new FormMember();
            m.ShowDialog();
            if (m.IsChanged)
                ShowForm();
        }

 

        private void ShowForm()
        {
            string _FirstName = txt.Text.Trim();
            string _LastName = textBox2.Text.Trim();
            long _NationalCode = maskedTextBox1.ConvertInt64();
            var _list = DbCommon.Context.Members.Select(p => new { p.FirstName, p.LastName, p.ID, Gender = p.Gender ? "مرد" : "زن", p.Email, p.Address, p.NationalCode, p.Major.MajorName, p.Mobile, p.Proof.ProofName, p.Tel }).
                Where(p => p.FirstName.Contains(_FirstName) && p.LastName.Contains(_LastName) && (p.NationalCode == _NationalCode || _NationalCode == 0));
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();

        }
        private void FormListMember_Load(object sender, EventArgs e)
        {
            ShowForm();
            var _list = DbCommon.Context.Members.Select(p => new { p.FirstName, p.LastName, p.ID, Gender = p.Gender ? "مرد" : "زن", p.Email, p.Address, p.NationalCode, p.Major.MajorName, p.Mobile, p.Proof.ProofName, p.Tel });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedMember==null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Members.Remove(SelectedMember);
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات حذف شد");
            SelectedMember = null;
            var _list = DbCommon.Context.Members.Select(p => new { p.FirstName, p.LastName, p.ID, Gender = p.Gender ? "مرد" : "زن", p.Email, p.Address, p.NationalCode, p.Major.MajorName, p.Mobile, p.Proof.ProofName, p.Tel });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
        }

        private void Edit_click(object sender, EventArgs e)
        {
            if(SelectedMember==null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            FormMember k = new FormMember(SelectedMember);
            k.ShowDialog();
            if (k.IsChanged)
                ShowForm();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Members.Select(p => new { p.FirstName, p.LastName, p.ID, Gender = p.Gender ? "مرد" : "زن", p.Email, p.Address, p.NationalCode, p.Major.MajorName, p.Mobile, p.Proof.ProofName, p.Tel });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (SelectedMember == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            FormMember k = new FormMember(SelectedMember, true);
            k.ShowDialog();
            if (k.IsChanged)
                ShowForm();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if(GridMembers.RowCount == 0)
            {
                MyMessagebox.ShowMessageValidation("اطلاعاتی جهت چاپ وجود ندارد");
                return;
            }
            stiReport1.Dictionary.Variables["DateStr"].Value = DateTime.Now.ToShortDateString();
            stiReport1.RegBusinessObject("ListMembers" , GridMember.DataSource);
            stiReport1.Render(true);
            stiReport1.Show();
        }

        private void GridMember_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            SelectedMember = DbCommon.Context.Members.Find(GridMember[10, e.RowIndex].Value);
            GridMember.Rows[e.RowIndex].Selected = true;
        }
    }
}
