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
    public partial class FormBook : Form
    {
        Book _book = null;
        public bool IsChanged { get; private set; }

        bool IsDisplay = false;
        public FormBook(Book pbook=null, bool PIsDisplay = false)
        {
            InitializeComponent();
            _book = pbook;
            IsChanged = false;
            IsDisplay = PIsDisplay;
        }
        private void Register_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text.Trim() == "" || ComboSubjectName.SelectedIndex == -1)
            {
                MyMessagebox.ShowMessageValidation();
            }
            if (_book == null)
            {
                _book = new Book();
                DbCommon.Context.Books.Add(_book);
            }
            _book.BookName = txtBookName.Text.Trim();
            _book.ISBN = txtISBN.Text.Trim();
            _book.Abstract = txtAbstract.Text.Trim();
            _book.SubjectID = Convert.ToInt32(ComboSubjectName.SelectedValue);
            _book.BookWriter = txtWriter.Text.Trim();
            DbCommon.Save();
            IsChanged = true;
            Close();
        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            ComboSubject();
            if (_book != null)
            {
                ShowOrginalinfo();
            }
            if(IsDisplay)
            {
                ShowOrginalinfo();
                DeActive();
            }
        }

        private void DeActive()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach((p) => { p.ReadOnly = true; });

            this.Controls.OfType<RichTextBox>().ToList().ForEach((p) => { p.ReadOnly = true; });

            this.Controls.OfType<ComboBox>().ToList().ForEach((p) => { p.DropDownStyle = ComboBoxStyle.Simple; });

            foreach (var item in this.Controls.OfType<ComboBox>().ToList())
            {
                item.DropDownStyle = ComboBoxStyle.Simple;
            }
            button2.Visible = false;
        }

        private void ShowOrginalinfo()
        {
            txtBookName.Text = _book.BookName;
            txtAbstract.Text = _book.Abstract;
            txtISBN.Text = _book.ISBN;
            ComboSubjectName.SelectedValue = _book.SubjectID;
            txtWriter.Text = _book.BookWriter;
        }
        private void ComboSubject()
        {
            ComboSubjectName.DataSource = DbCommon.Context.Subjects.ToList();
            ComboSubjectName.DisplayMember = "SubjectName";
            ComboSubjectName.ValueMember = "ID";
            ComboSubjectName.SelectedIndex = -1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
