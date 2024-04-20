namespace Assignment
{
    partial class Issued
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idBook = new System.Windows.Forms.ComboBox();
            this.quantiTxt = new System.Windows.Forms.TextBox();
            this.bookNameTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findBt = new System.Windows.Forms.Button();
            this.extendMStxt = new System.Windows.Forms.TextBox();
            this.ExtendBookTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classNameTxt = new System.Windows.Forms.TextBox();
            this.mssvTxt = new System.Windows.Forms.TextBox();
            this.studentNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 787);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.updateBt);
            this.tabPage1.Controls.Add(this.addBt);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 758);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mượn sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(885, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gia hạn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // updateBt
            // 
            this.updateBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.updateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBt.ForeColor = System.Drawing.Color.White;
            this.updateBt.Location = new System.Drawing.Point(684, 265);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(163, 47);
            this.updateBt.TabIndex = 2;
            this.updateBt.Text = "Cập nhật";
            this.updateBt.UseVisualStyleBackColor = false;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.addBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.ForeColor = System.Drawing.Color.White;
            this.addBt.Location = new System.Drawing.Point(484, 265);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(163, 47);
            this.addBt.TabIndex = 2;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idBook);
            this.groupBox2.Controls.Add(this.quantiTxt);
            this.groupBox2.Controls.Add(this.bookNameTxt);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(484, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mượn sách";
            // 
            // idBook
            // 
            this.idBook.FormattingEnabled = true;
            this.idBook.Location = new System.Drawing.Point(101, 35);
            this.idBook.Name = "idBook";
            this.idBook.Size = new System.Drawing.Size(198, 24);
            this.idBook.TabIndex = 4;
            // 
            // quantiTxt
            // 
            this.quantiTxt.Location = new System.Drawing.Point(101, 152);
            this.quantiTxt.Name = "quantiTxt";
            this.quantiTxt.Size = new System.Drawing.Size(198, 22);
            this.quantiTxt.TabIndex = 1;
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Location = new System.Drawing.Point(101, 96);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.ReadOnly = true;
            this.bookNameTxt.Size = new System.Drawing.Size(198, 22);
            this.bookNameTxt.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(399, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findBt);
            this.groupBox3.Controls.Add(this.extendMStxt);
            this.groupBox3.Controls.Add(this.ExtendBookTxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(32, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 184);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin học sinh";
            // 
            // findBt
            // 
            this.findBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.findBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBt.ForeColor = System.Drawing.Color.White;
            this.findBt.Location = new System.Drawing.Point(104, 135);
            this.findBt.Name = "findBt";
            this.findBt.Size = new System.Drawing.Size(114, 33);
            this.findBt.TabIndex = 2;
            this.findBt.Text = "Tìm";
            this.findBt.UseVisualStyleBackColor = false;
            // 
            // extendMStxt
            // 
            this.extendMStxt.Location = new System.Drawing.Point(105, 46);
            this.extendMStxt.Name = "extendMStxt";
            this.extendMStxt.Size = new System.Drawing.Size(264, 22);
            this.extendMStxt.TabIndex = 1;
            // 
            // ExtendBookTxt
            // 
            this.ExtendBookTxt.Location = new System.Drawing.Point(104, 96);
            this.ExtendBookTxt.Name = "ExtendBookTxt";
            this.ExtendBookTxt.Size = new System.Drawing.Size(264, 22);
            this.ExtendBookTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "MSSV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classNameTxt);
            this.groupBox1.Controls.Add(this.mssvTxt);
            this.groupBox1.Controls.Add(this.studentNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // classNameTxt
            // 
            this.classNameTxt.Location = new System.Drawing.Point(104, 153);
            this.classNameTxt.Name = "classNameTxt";
            this.classNameTxt.Size = new System.Drawing.Size(264, 22);
            this.classNameTxt.TabIndex = 1;
            // 
            // mssvTxt
            // 
            this.mssvTxt.Location = new System.Drawing.Point(104, 97);
            this.mssvTxt.Name = "mssvTxt";
            this.mssvTxt.Size = new System.Drawing.Size(264, 22);
            this.mssvTxt.TabIndex = 1;
            // 
            // studentNameTxt
            // 
            this.studentNameTxt.Location = new System.Drawing.Point(104, 32);
            this.studentNameTxt.Name = "studentNameTxt";
            this.studentNameTxt.Size = new System.Drawing.Size(264, 22);
            this.studentNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.StudentName,
            this.Class,
            this.ID,
            this.bookName,
            this.BorrowDate,
            this.ReturnDate,
            this.Quanti});
            this.dataGridView1.Location = new System.Drawing.Point(15, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Tên học sinh";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "BookId";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Tên sách";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 150;
            // 
            // BorrowDate
            // 
            this.BorrowDate.HeaderText = "Ngày mượn";
            this.BorrowDate.MinimumWidth = 6;
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.Width = 125;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Ngày trả";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 125;
            // 
            // Quanti
            // 
            this.Quanti.HeaderText = "Số lượng";
            this.Quanti.MinimumWidth = 6;
            this.Quanti.Name = "Quanti";
            this.Quanti.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1136, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trả sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Issued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Issued";
            this.Size = new System.Drawing.Size(1150, 793);
            this.Load += new System.EventHandler(this.Issued_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanti;
        private System.Windows.Forms.TextBox bookNameTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentNameTxt;
        private System.Windows.Forms.ComboBox idBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.TextBox quantiTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button findBt;
        private System.Windows.Forms.TextBox extendMStxt;
        private System.Windows.Forms.TextBox ExtendBookTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox classNameTxt;
        private System.Windows.Forms.TextBox mssvTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
