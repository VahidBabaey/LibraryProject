using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormLinq : Form
    {
        public FormLinq()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            DbCommon.Context.Configuration.LazyLoadingEnabled = false;
            DbCommon.Context.Configuration.ProxyCreationEnabled = false;


            var _list2 =from _member in DbCommon.Context.Members
                        join _proof in DbCommon.Context.Proofs on _member.ProofID equals _proof.ID
                         where _member.NationalCode>10
                         select new {_member.LastName,_member.FirstName,_member.ID,_member.Address,_member.Tel,_proof.ProofName};
        }
    }
}
