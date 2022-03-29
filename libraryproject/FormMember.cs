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
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace libraryproject
{
    public partial class FormMember : Form
    {
            Member _member = null;
            public bool IsChanged  { get; private set;}

            bool IsDisplay = false;
            public FormMember(Member pmember=null, bool PIsDisplay = false)
        {

            InitializeComponent();
          
            _member = pmember;

            IsChanged = false;

            IsDisplay = PIsDisplay;
        }

            private void Register_click(object sender, EventArgs e)
            {
                if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtNationalCode.Text.Trim() == "")
                {
                    MyMessagebox.ShowMessageValidation();
                    return;
                }

                if (_member == null)
                {
                    _member = new Member();
                    DbCommon.Context.Members.Add(_member);
                }



                _member.FirstName = txtFirstName.Text.Trim();
                _member.LastName = txtLastName.Text.Trim();
                _member.Address = txtAddr.Text.Trim();
                _member.Email = txtEmail.Text.Trim();
                _member.MajorID = Convert.ToInt32(ComboMajor.SelectedValue);
                _member.ProofID = Convert.ToInt32(ComboProof.SelectedValue);
                _member.NationalCode = txtNationalCode.ConvertInt64();
                _member.Tel = txtTel.ConvertInt64();
                _member.Mobile = txtMob.ConvertInt64();
                _member.Gender = ComboGender.SelectedIndex == 0;
                if(PicMember.Image != null)
                {
                    Pic _pic = new Pic();
                    MemoryStream _memory = new MemoryStream();
                    PicMember.Image.Save(_memory, ImageFormat.Jpeg);
                    _pic.Picture = _memory.GetBuffer();
                    _member.Pic = _pic;
                }
                else
                {
                    _member.Pic = null;
                }
                DbCommon.Save();
                IsChanged = true;
                Close();

            }

        private void FormMember_Load(object sender, EventArgs e)
        {
            ShowMajers();
            ShowProofs();
            if (_member != null)
            {
                showoriginalinfo();
            }
            if(IsDisplay)
            {
                showoriginalinfo();
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

        private void showoriginalinfo()
        {
            txtFirstName.Text = _member.FirstName;
            txtLastName.Text = _member.LastName;
            txtAddr.Text = _member.Address;
            txtEmail.Text = _member.Email;
            txtMob.Text = _member.Mobile.ToString();
            txtTel.Text = _member.Tel.ToString();
            txtNationalCode.Text = _member.NationalCode.ToString();
            ComboMajor.SelectedValue = _member.MajorID;
            ComboProof.SelectedValue = _member.ProofID;
            ComboGender.SelectedIndex = _member.Gender ? 0 : 1;

            if(_member.Pic != null)
            {
                MemoryStream _memory = new MemoryStream(_member.Pic.Picture);
                PicMember.Image = Image.FromStream(_memory);
            }
        }

        private void ShowProofs()
        {
            ComboProof.DataSource = DbCommon.Context.Proofs.ToList();
            ComboProof.DisplayMember = "ProofName";
            ComboProof.ValueMember = "ID";
            ComboProof.SelectedIndex = -1;
        }

        private void ShowMajers()
        {
            ComboMajor.DataSource = DbCommon.Context.Majors.ToList();
            ComboMajor.DisplayMember = "MajorName";
            ComboMajor.ValueMember = "ID";
            ComboMajor.SelectedIndex = -1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenFile_Dialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "تصاویر (*.jpg) | *.jpg";
            if(op.ShowDialog()==DialogResult.OK)
            {
                PicMember.Load(op.FileName);
            }
        }


    }
}
