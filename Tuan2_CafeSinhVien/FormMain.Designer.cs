
namespace Tuan2_CafeSinhVien
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radSua = new System.Windows.Forms.RadioButton();
            this.radDa = new System.Windows.Forms.RadioButton();
            this.radSuaDa = new System.Windows.Forms.RadioButton();
            this.radKem = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(283, 26);
            this.txtTen.TabIndex = 2;
            this.txtTen.Text = "Lưu Quang Đức";
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // cbx
            // 
            this.cbx.AutoSize = true;
            this.cbx.Checked = true;
            this.cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx.Location = new System.Drawing.Point(152, 110);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(96, 24);
            this.cbx.TabIndex = 3;
            this.cbx.Text = "Sinh viên";
            this.cbx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDa);
            this.groupBox1.Controls.Add(this.radKem);
            this.groupBox1.Controls.Add(this.radSuaDa);
            this.groupBox1.Controls.Add(this.radSua);
            this.groupBox1.Controls.Add(this.radDen);
            this.groupBox1.Location = new System.Drawing.Point(152, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại cafe";
            // 
            // radDen
            // 
            this.radDen.AutoSize = true;
            this.radDen.Location = new System.Drawing.Point(7, 26);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(94, 24);
            this.radDen.TabIndex = 0;
            this.radDen.Text = "Cafe đen";
            this.radDen.UseVisualStyleBackColor = true;
            // 
            // radSua
            // 
            this.radSua.AutoSize = true;
            this.radSua.Checked = true;
            this.radSua.Location = new System.Drawing.Point(7, 56);
            this.radSua.Name = "radSua";
            this.radSua.Size = new System.Drawing.Size(94, 24);
            this.radSua.TabIndex = 0;
            this.radSua.TabStop = true;
            this.radSua.Text = "Cafe sữa";
            this.radSua.UseVisualStyleBackColor = true;
            // 
            // radDa
            // 
            this.radDa.AutoSize = true;
            this.radDa.Location = new System.Drawing.Point(7, 86);
            this.radDa.Name = "radDa";
            this.radDa.Size = new System.Drawing.Size(85, 24);
            this.radDa.TabIndex = 0;
            this.radDa.Text = "Cafe đá";
            this.radDa.UseVisualStyleBackColor = true;
            // 
            // radSuaDa
            // 
            this.radSuaDa.AutoSize = true;
            this.radSuaDa.Location = new System.Drawing.Point(135, 26);
            this.radSuaDa.Name = "radSuaDa";
            this.radSuaDa.Size = new System.Drawing.Size(117, 24);
            this.radSuaDa.TabIndex = 0;
            this.radSuaDa.Text = "Cafe sữa đá";
            this.radSuaDa.UseVisualStyleBackColor = true;
            // 
            // radKem
            // 
            this.radKem.AutoSize = true;
            this.radKem.Location = new System.Drawing.Point(135, 56);
            this.radKem.Name = "radKem";
            this.radKem.Size = new System.Drawing.Size(98, 24);
            this.radKem.TabIndex = 0;
            this.radKem.Text = "Cafe kem";
            this.radKem.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Enabled = false;
            this.btnTinhTien.Location = new System.Drawing.Point(9, 298);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(102, 39);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Enabled = false;
            this.btnNhapLai.Location = new System.Drawing.Point(118, 298);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(102, 39);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(227, 298);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(102, 39);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(336, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số khách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(152, 357);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(283, 26);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.Text = "10";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(152, 389);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(283, 26);
            this.txtTongTien.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 434);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDa;
        private System.Windows.Forms.RadioButton radKem;
        private System.Windows.Forms.RadioButton radSuaDa;
        private System.Windows.Forms.RadioButton radSua;
        private System.Windows.Forms.RadioButton radDen;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}

