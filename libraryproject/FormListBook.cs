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
    public partial class FormListBook : Form
    {
        Book SelectBook = null;
        public FormListBook()
        {
            InitializeComponent();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            FormBook q = new FormBook();
            q.ShowDialog();
            if (q.IsChanged)
                ShowForm();
        }

        private void ShowForm()
        {
            string _bookname = txtBookName.Text.Trim();
            var _list = DbCommon.Context.Books.Select(p => new { p.BookName, p.Abstract, p.ISBN,p.ID, p.Subject.SubjectName, p.BookWriter}).
                Where(p => p.BookName.Contains(_bookname));
            GridBook.AutoGenerateColumns = false;
            GridBook.DataSource = _list.ToList();

        }
        private void GridBook_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            SelectBook = DbCommon.Context.Books.Find(GridBook["ColID", e.RowIndex].Value);
            GridBook.Rows[e.RowIndex].Selected = true;
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectBook == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Books.Remove(SelectBook);
            DbCommon.Context.SaveChanges();
            SelectBook = null;
            var _list = DbCommon.Context.Books.Select(p => new { p.BookName, p.Abstract, p.ISBN, p.ID, p.Subject.SubjectName, p.BookWriter });
            GridBook.AutoGenerateColumns = false;
            GridBook.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectBook == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            FormBook a = new FormBook(SelectBook);
            a.ShowDialog();
            if (a.IsChanged)
            ShowForm();
        }
        private void FormListBook_Load(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Books.Select(p => new { p.BookName, p.Abstract, p.ISBN, p.ID, p.Subject.SubjectName, p.BookWriter });
            GridBook.AutoGenerateColumns = false;
            GridBook.DataSource = _list.ToList();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (SelectBook == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            FormBook a = new FormBook(SelectBook, true);
            a.ShowDialog();
            if (a.IsChanged)
                ShowForm();
        }
    }
}
