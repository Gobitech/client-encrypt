namespace WF1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMatkhau = new System.Windows.Forms.TextBox();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.textBoxHoten = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.luong = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.textBoxTendn = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.manv = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tendn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thoat = new System.Windows.Forms.Button();
            this.khong = new System.Windows.Forms.Button();
            this.ghiluu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(329, 33);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(399, 39);
            this.title.TabIndex = 0;
            this.title.Text = "DANH MỤC NHÂN VIÊN";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxMatkhau);
            this.panel1.Controls.Add(this.textBoxLuong);
            this.panel1.Controls.Add(this.textBoxHoten);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.luong);
            this.panel1.Controls.Add(this.hoten);
            this.panel1.Controls.Add(this.textBoxTendn);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxMaNV);
            this.panel1.Controls.Add(this.manv);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.tendn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(60, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 239);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxMatkhau
            // 
            this.textBoxMatkhau.Location = new System.Drawing.Point(657, 172);
            this.textBoxMatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMatkhau.Name = "textBoxMatkhau";
            this.textBoxMatkhau.PasswordChar = '*';
            this.textBoxMatkhau.Size = new System.Drawing.Size(251, 30);
            this.textBoxMatkhau.TabIndex = 12;
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(657, 108);
            this.textBoxLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(251, 30);
            this.textBoxLuong.TabIndex = 11;
            // 
            // textBoxHoten
            // 
            this.textBoxHoten.Location = new System.Drawing.Point(657, 49);
            this.textBoxHoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHoten.Name = "textBoxHoten";
            this.textBoxHoten.Size = new System.Drawing.Size(251, 30);
            this.textBoxHoten.TabIndex = 10;
            this.textBoxHoten.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(523, 180);
            this.matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(93, 25);
            this.matkhau.TabIndex = 9;
            this.matkhau.Text = "Mật khẩu";
            // 
            // luong
            // 
            this.luong.AutoSize = true;
            this.luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luong.Location = new System.Drawing.Point(523, 112);
            this.luong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(67, 25);
            this.luong.TabIndex = 8;
            this.luong.Text = "Lương";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.Location = new System.Drawing.Point(523, 53);
            this.hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(69, 25);
            this.hoten.TabIndex = 7;
            this.hoten.Text = "Họ tên";
            this.hoten.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTendn
            // 
            this.textBoxTendn.Location = new System.Drawing.Point(216, 172);
            this.textBoxTendn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTendn.Name = "textBoxTendn";
            this.textBoxTendn.Size = new System.Drawing.Size(251, 30);
            this.textBoxTendn.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(216, 105);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 30);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(216, 46);
            this.textBoxMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(251, 30);
            this.textBoxMaNV.TabIndex = 4;
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv.Location = new System.Drawing.Point(51, 53);
            this.manv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(68, 25);
            this.manv.TabIndex = 3;
            this.manv.Text = "Mã NV";
            this.manv.Click += new System.EventHandler(this.label4_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(51, 112);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 25);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // tendn
            // 
            this.tendn.AutoSize = true;
            this.tendn.Location = new System.Drawing.Point(51, 180);
            this.tendn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tendn.Name = "tendn";
            this.tendn.Size = new System.Drawing.Size(145, 25);
            this.tendn.TabIndex = 1;
            this.tendn.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.thoat);
            this.panel3.Controls.Add(this.khong);
            this.panel3.Controls.Add(this.ghiluu);
            this.panel3.Controls.Add(this.sua);
            this.panel3.Controls.Add(this.xoa);
            this.panel3.Controls.Add(this.them);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(60, 372);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 341);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 188);
            this.dataGridView1.TabIndex = 4;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(812, 284);
            this.thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 28);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // khong
            // 
            this.khong.Location = new System.Drawing.Point(660, 284);
            this.khong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khong.Name = "khong";
            this.khong.Size = new System.Drawing.Size(100, 28);
            this.khong.TabIndex = 5;
            this.khong.Text = "Không";
            this.khong.UseVisualStyleBackColor = true;
            // 
            // ghiluu
            // 
            this.ghiluu.Location = new System.Drawing.Point(497, 284);
            this.ghiluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ghiluu.Name = "ghiluu";
            this.ghiluu.Size = new System.Drawing.Size(100, 28);
            this.ghiluu.TabIndex = 4;
            this.ghiluu.Text = "Ghi/Lưu";
            this.ghiluu.UseVisualStyleBackColor = true;
            this.ghiluu.Click += new System.EventHandler(this.ghiluu_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(336, 284);
            this.sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 28);
            this.sua.TabIndex = 3;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(179, 284);
            this.xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 28);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(29, 284);
            this.them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(100, 28);
            this.them.TabIndex = 1;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(-31, 272);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(980, 49);
            this.dataGridView2.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 746);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tendn;
        private System.Windows.Forms.TextBox textBoxTendn;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label luong;
        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.TextBox textBoxMatkhau;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.TextBox textBoxHoten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button khong;
        private System.Windows.Forms.Button ghiluu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}