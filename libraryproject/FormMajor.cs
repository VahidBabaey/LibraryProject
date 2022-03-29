using libraryproject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryproject
{
    public partial class FormMajor : Form
    {
        Major SelectedMajor = null;
        public FormMajor()
        {
            InitializeComponent();
        }

        private void FormMajor_Load(object sender, EventArgs e)
        {
            ShowMajors();
        }

        private void ShowMajors()
        {
            GridMajor.AutoGenerateColumns = false;
            GridMajor.DataSource = DbCommon.Context.Majors.ToList();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            if (txtMajorName.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation();
                return;
            }
            Major _major = new Major();
            _major.MajorName = txtMajorName.Text.Trim();
            DbCommon.Context.Majors.Add(_major);
            DbCommon.Context.SaveChanges();
            ShowMajors();
            ClearText();
        }

        private void ClearText()
        {
            txtMajorName.Text = "";
            txtMajorName.Focus();
        }

        private void GridProof_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedMajor = DbCommon.Context.Majors.Find(GridMajor[1, e.RowIndex].Value);
            txtMajorName.Text = SelectedMajor.MajorName;

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedMajor == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Majors.Remove(SelectedMajor);
            DbCommon.Context.SaveChanges();
            SelectedMajor = null;
            ShowMajors();
            ClearText();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedMajor == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            SelectedMajor.MajorName = txtMajorName.Text.Trim();
            DbCommon.Context.SaveChanges();
            SelectedMajor = null;
            ShowMajors();
            ClearText();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
