using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using libraryproject.Model;

namespace libraryproject
{
    public partial class FormSubject : Form
    {
        Subject SelectedSubject = null;
        public FormSubject()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation();
                return;
            }

             Subject _subject = new Subject();
            _subject.SubjectName = txtSubjectName.Text.Trim();
            DbCommon.Context.Subjects.Add(_subject);
            DbCommon.Context.SaveChanges();
            ShowSubject();
            ClearText();


        }

        private void ClearText()
        {
            txtSubjectName.Text = "";
            txtSubjectName.Focus();
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            ShowSubject();
        }

        private void ShowSubject()
        {
            GridSubject.AutoGenerateColumns = false;
            GridSubject.DataSource = DbCommon.Context.Subjects.ToList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedSubject == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Subjects.Remove(SelectedSubject);
            DbCommon.Context.SaveChanges();
            SelectedSubject = null;
            ShowSubject();
            ClearText();
        }

        private void GridSubject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedSubject = DbCommon.Context.Subjects.Find(GridSubject[1, e.RowIndex].Value);
            txtSubjectName.Text = SelectedSubject.SubjectName;
        }

        private void Edite_Click(object sender, EventArgs e)
        {
            SelectedSubject.SubjectName = txtSubjectName.Text.Trim();
            ShowSubject();
            ClearText();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
