using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_CafeSinhVien
{
    public partial class FormMain : Form
    {
        private const int DEN = 20000;
        private const int DA = 25000;
        private const int SUA = 25000;
        private const int SUA_DA = 30000;
        private const int KEM = 35000;
        private int tongTien = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = tongTien.ToString("#.###,##");
            tongTien = 0;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double tien = tinhTien();
            tongTien += (int)tien;
        }

        private double tinhTien()
        {
            double giam = 0.8;
            int soLuong = int.Parse(txtSoLuong.Text);
            if (cbx.Checked)
                giam = 0.2;
            if (radDa.Checked)
                return soLuong * giam * DA;
            else if(radDen.Checked)
                return soLuong * giam * DEN;
            else if(radKem.Checked)
                return soLuong * giam * KEM;
            else if(radSua.Checked)
                return soLuong * giam * SUA;
            else if(radSuaDa.Checked)
                return soLuong * giam * SUA_DA;
            return 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
            disableButton();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (kiemTraDuLieuHopLe())
                enableButton();
            else
                disableButton();
        }

        private void disableButton()
        {
            btnTinhTien.Enabled = btnThanhToan.Enabled = btnNhapLai.Enabled = false;
        }

        private void enableButton()
        {
            btnTinhTien.Enabled = btnThanhToan.Enabled = btnNhapLai.Enabled = true;
        }

        private bool kiemTraDuLieuHopLe()
        {
            return  !String.IsNullOrEmpty(txtTen.Text) &&
                    !String.IsNullOrEmpty(txtSoLuong.Text);
        }

        private void clearForm()
        {
            txtTen.Clear();
            txtSoLuong.Clear();
            txtTongTien.Clear();
        }
    }
}
