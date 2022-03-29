using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormBooksForSubject : Form
    {
        Subject Subject = null;
        public FormBooksForSubject(Subject PSubject)
        {

            InitializeComponent();
            Subject = PSubject;
           
        }

        private void FormBooksForSubject_Load(object sender, EventArgs e)
        {
            this.Text += " " +Subject.SubjectName ;
            ShowBooks();

        }

        private void ShowBooks()
        {
            GridBooks.AutoGenerateColumns = false;
            GridBooks.DataSource = Subject.Books.ToList();
        }
    }
}
