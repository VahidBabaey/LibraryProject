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
    public partial class FormListBorrow : Form
    {
        Member SelectedMember = null;
        FormBorrow SelectedFormBorrow = null;
        public FormListBorrow()
        {
            InitializeComponent();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            if(SelectedMember == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا عضو مورد نظر را از جدول اعضا انتخاب کنید!");
                return;
            }
            FormRegisterBorrow j = new FormRegisterBorrow(SelectedMember);
            j.ShowDialog();
            if (j.IsChanged)
                ShowBorrowsForSelectedMember();
        }

        

        private void Search_Click(object sender, EventArgs e)
        {
            ShowMembers();
        }

        private void ShowMembers()
        {
           string _firstname = txtFirstName.Text.Trim();
           string _lastname = txtLastName.Text.Trim();
           long _nationalcode = txtNationalCode.ConvertInt64();
           var _list = DbCommon.Context.Members.Where(p => p.FirstName.Contains(_firstname) && p.LastName.Contains(_lastname) && (p.NationalCode == _nationalcode || _nationalcode == 0))
               .Select(p => new { FullName = p.FirstName + " " + p.LastName,p.ID, p.NationalCode });
           GridMembers.AutoGenerateColumns = false;
           GridMembers.DataSource = _list.ToList();
        }

        private void GridMembers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridMembers[2, e.RowIndex].Value);
            SelectedMember = DbCommon.Context.Members.SingleOrDefault(p => p.ID == id);
            GridMembers.Rows[e.RowIndex].Selected = true;
            if(SelectedMember != null)
            {
                ShowBorrowsForSelectedMember();
            }
        }
        private void ShowBorrowsForSelectedMember()
        {
            GridBorrows.AutoGenerateColumns = false;
            GridBorrows.DataSource = SelectedMember.FormBorrows.Select(p => new { p.NumDay, p.ID, p.BorrowDate, p.Book.Subject.SubjectName, p.Book.BookName }).ToList();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if(SelectedMember == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا عضو مورد نظر را از جدول اعضا انتخاب کنید!");
                return;
            }
            if(SelectedFormBorrow == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا موردی را از جدول کتاب های امانت انتخاب کنید!");
                return;
            }
            FormRegisterBorrow j = new FormRegisterBorrow(SelectedMember, SelectedFormBorrow);
            j.ShowDialog();
            GridBorrows.AutoGenerateColumns = false;
            GridBorrows.DataSource = SelectedMember.FormBorrows.Select(p => new { p.NumDay, p.ID, p.BorrowDate, p.Book.Subject.SubjectName, p.Book.BookName }).ToList();
        }

        private void GridBorrows_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(GridBorrows[4, e.RowIndex].Value);
            SelectedFormBorrow = DbCommon.Context.FormBorrows.SingleOrDefault(p => p.ID == id);
            GridBorrows.Rows[e.RowIndex].Selected = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DbCommon.Context.FormBorrows.Remove(SelectedFormBorrow);
            DbCommon.Save();
            SelectedFormBorrow = null;
            ShowBorrowsForSelectedMember();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshM_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Members.Select(p => new { FullName = p.FirstName + " " + p.LastName, p.ID, p.NationalCode });
            GridMembers.AutoGenerateColumns = false;
            GridMembers.DataSource = _list.ToList();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (SelectedMember == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا عضو مورد نظر را از جدول اعضا انتخاب کنید!");
                return;
            }
            if (SelectedFormBorrow == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا موردی را از جدول کتاب های امانت انتخاب کنید!");
                return;
            }
            FormRegisterBorrow j = new FormRegisterBorrow(SelectedMember, SelectedFormBorrow, true);
            j.ShowDialog();
            GridBorrows.AutoGenerateColumns = false;
            GridBorrows.DataSource = SelectedMember.FormBorrows.Select(p => new { p.NumDay, p.ID, p.BorrowDate, p.Book.Subject.SubjectName, p.Book.BookName }).ToList();
        }

        private void FormListBorrow_Load(object sender, EventArgs e)
        {

        }


    }
}
