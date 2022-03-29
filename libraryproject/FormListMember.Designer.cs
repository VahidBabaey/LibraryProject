namespace libraryproject
{
    partial class FormListMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridMember = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xzvzfsadf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zxcedfsfd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMember)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMember
            // 
            this.GridMember.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMember.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Columnn,
            this.Columnnn,
            this.Colum,
            this.crsg,
            this.sdv,
            this.cvcv,
            this.dasd,
            this.xzvzfsadf,
            this.zxcedfsfd,
            this.id});
            this.GridMember.EnableHeadersVisualStyles = false;
            this.GridMember.GridColor = System.Drawing.Color.LightSeaGreen;
            this.GridMember.Location = new System.Drawing.Point(193, 131);
            this.GridMember.Margin = new System.Windows.Forms.Padding(4);
            this.GridMember.Name = "GridMember";
            this.GridMember.RowHeadersWidth = 51;
            this.GridMember.Size = new System.Drawing.Size(1195, 486);
            this.GridMember.TabIndex = 15;
            this.GridMember.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMember_CellMouseClick);
            // 
            // Column
            // 
            this.Column.DataPropertyName = "FirstName";
            this.Column.HeaderText = "نام";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 125;
            // 
            // Columnn
            // 
            this.Columnn.DataPropertyName = "LastName";
            this.Columnn.HeaderText = "نام خانوادگی";
            this.Columnn.MinimumWidth = 6;
            this.Columnn.Name = "Columnn";
            this.Columnn.ReadOnly = true;
            this.Columnn.Width = 125;
            // 
            // Columnnn
            // 
            this.Columnnn.DataPropertyName = "Gender";
            this.Columnnn.HeaderText = "جنسیت";
            this.Columnnn.MinimumWidth = 6;
            this.Columnnn.Name = "Columnnn";
            this.Columnnn.ReadOnly = true;
            this.Columnnn.Width = 125;
            // 
            // Colum
            // 
            this.Colum.DataPropertyName = "Tel";
            this.Colum.HeaderText = "تلفن";
            this.Colum.MinimumWidth = 6;
            this.Colum.Name = "Colum";
            this.Colum.ReadOnly = true;
            this.Colum.Width = 125;
            // 
            // crsg
            // 
            this.crsg.DataPropertyName = "Mobile";
            this.crsg.HeaderText = "موبایل";
            this.crsg.MinimumWidth = 6;
            this.crsg.Name = "crsg";
            this.crsg.ReadOnly = true;
            this.crsg.Width = 125;
            // 
            // sdv
            // 
            this.sdv.DataPropertyName = "Email";
            this.sdv.HeaderText = "ایمیل";
            this.sdv.MinimumWidth = 6;
            this.sdv.Name = "sdv";
            this.sdv.ReadOnly = true;
            this.sdv.Width = 125;
            // 
            // cvcv
            // 
            this.cvcv.DataPropertyName = "Address";
            this.cvcv.HeaderText = "آدرس";
            this.cvcv.MinimumWidth = 6;
            this.cvcv.Name = "cvcv";
            this.cvcv.ReadOnly = true;
            this.cvcv.Width = 125;
            // 
            // dasd
            // 
            this.dasd.DataPropertyName = "MajorName";
            this.dasd.HeaderText = "رشته";
            this.dasd.MinimumWidth = 6;
            this.dasd.Name = "dasd";
            this.dasd.ReadOnly = true;
            this.dasd.Width = 125;
            // 
            // xzvzfsadf
            // 
            this.xzvzfsadf.DataPropertyName = "ProofName";
            this.xzvzfsadf.HeaderText = "مدرک";
            this.xzvzfsadf.MinimumWidth = 6;
            this.xzvzfsadf.Name = "xzvzfsadf";
            this.xzvzfsadf.ReadOnly = true;
            this.xzvzfsadf.Width = 125;
            // 
            // zxcedfsfd
            // 
            this.zxcedfsfd.DataPropertyName = "NationalCode";
            this.zxcedfsfd.HeaderText = "کد ملی";
            this.zxcedfsfd.MinimumWidth = 6;
            this.zxcedfsfd.Name = "zxcedfsfd";
            this.zxcedfsfd.ReadOnly = true;
            this.zxcedfsfd.Width = 250;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button9.Image = global::libraryproject.Properties.Resources.add_icon__1_;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(419, 624);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 55);
            this.button9.TabIndex = 16;
            this.button9.Text = "ثبت";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button10.Image = global::libraryproject.Properties.Resources.edit_validated_icon;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(306, 624);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 55);
            this.button10.TabIndex = 17;
            this.button10.Text = "ویرایش";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Edit_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Window;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button11.Image = global::libraryproject.Properties.Resources.Close_2_icon;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.Location = new System.Drawing.Point(193, 624);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 55);
            this.button11.TabIndex = 18;
            this.button11.Text = "حذف";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button12.Image = global::libraryproject.Properties.Resources.Actions_edit_undo_icon;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.Location = new System.Drawing.Point(1395, 131);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 55);
            this.button12.TabIndex = 19;
            this.button12.Text = "بروزرسانی";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(590, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(215, 41);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "کدملی:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "نام خانوادگی:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 22;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(577, 39);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 22);
            this.txt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "نام:";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Window;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button13.Image = global::libraryproject.Properties.Resources.Search_icon;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.Location = new System.Drawing.Point(477, 68);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(107, 55);
            this.button13.TabIndex = 21;
            this.button13.Text = "جستحو";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Search_Click);
            // 
            // FormListMember
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1838, 879);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.GridMember);
            this.Name = "FormListMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست اعضا";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridMember)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox txtNationalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridMember;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn xzvzfsadf;
        private System.Windows.Forms.DataGridViewTextBoxColumn zxcedfsfd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button13;
    }
}