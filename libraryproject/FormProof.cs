
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

namespace Library
{
    public partial class FormProof : Form
    {
        Proof SelectedProof = null;
        public FormProof()
        {
            InitializeComponent();
        }

        private void FormProof_Load(object sender, EventArgs e)
        {
            ShowProofs();
        }

        private void ShowProofs()
        {
            GridProof.AutoGenerateColumns = false;
            GridProof.DataSource = DbCommon.Context.Proofs.ToList();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            if(txtProofName.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation();
                return;
            }
            Proof _proof = new Proof();
            _proof.ProofName = txtProofName.Text.Trim();
            DbCommon.Context.Proofs.Add(_proof);
            DbCommon.Context.SaveChanges();
            ShowProofs();
            ClearText();
        }

        private void ClearText()
        {
            txtProofName.Text = "";
            txtProofName.Focus();
        }

        private void GridProof_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedProof = DbCommon.Context.Proofs.Find(GridProof[1, e.RowIndex].Value);
            txtProofName.Text = SelectedProof.ProofName;

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedProof == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Proofs.Remove(SelectedProof);
            DbCommon.Context.SaveChanges();
            SelectedProof = null;
            ShowProofs();
            ClearText();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedProof == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            SelectedProof.ProofName = txtProofName.Text.Trim();
            DbCommon.Context.SaveChanges();
            SelectedProof = null;
            ShowProofs();
            ClearText();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
