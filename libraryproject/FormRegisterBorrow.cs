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
    public partial class FormRegisterBorrow : Form
    {
        Member _member = null;
        FormBorrow _formborrow = null;
        public bool IsChanged { get; private set; }

        bool IsDisplay = false;
        public FormRegisterBorrow(Member pmember, FormBorrow pFormBorrow = null, bool PIsDisplay = false)
        {
            InitializeComponent();
            _member = pmember;
            _formborrow = pFormBorrow;
            IsChanged = false;
            IsDisplay = PIsDisplay;
        }

        private void FormRegisterBorrow_Load(object sender, EventArgs e)
        {
            this.Text +=   " برای " + _member.FirstName + " " + _member.LastName;
            ShowSubject();
            if(_formborrow != null)
            {
                ShowOriginalinfo();
            }
            if(IsDisplay)
            {
                ShowOriginalinfo();
                DeActive();
            }
        }

        private void DeActive()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach((p) => { p.ReadOnly = true; });

            foreach (var item in this.Controls.OfType<ComboBox>().ToList())
            {
                item.DropDownStyle = ComboBoxStyle.Simple;
            }
            button2.Visible = false;
        }

        private void ShowOriginalinfo()
        {
            ComboSubject.SelectedValue = _formborrow.Book.SubjectID;
            ShowBooksfoeSubject();
            ComboBook.SelectedValue = _formborrow.BookID;
            txtNumday.Text = _formborrow.NumDay.ToString();
            txtdate.Text = _formborrow.BorrowDate.ToString(); 
            
        }

        private void ShowSubject()
        {
            ComboSubject.DataSource = DbCommon.Context.Subjects.ToList();
            ComboSubject.DisplayMember = "SubjectName";
            ComboSubject.ValueMember = "ID";
            ComboSubject.SelectedIndex = -1;
        }

        private void ComboSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowBooksfoeSubject();
        }

        private void ShowBooksfoeSubject()
        {
            int _subjectid = ComboSubject.GetValue();
            ComboBook.DataSource = DbCommon.Context.Books.Where(p => p.SubjectID == _subjectid).ToList();
            ComboBook.DisplayMember = "BookName";
            ComboBook.ValueMember = "ID";
            ComboBook.SelectedIndex = -1;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(ComboSubject.SelectedIndex == -1 || ComboBook.SelectedIndex == -1)
            {
                MyMessagebox.ShowMessageValidation();
                return;
            }
            if(_formborrow == null)
            {
                _formborrow = new FormBorrow();
                _member.FormBorrows.Add(_formborrow);
            }
            _formborrow.BookID = ComboBook.GetValue();
            _formborrow.BorrowDate = txtdate.Text.Trim();
            _formborrow.NumDay = txtNumday.ConvertInt32();
            DbCommon.Save();
            IsChanged = true;
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
