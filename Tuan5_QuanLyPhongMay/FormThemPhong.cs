using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_QuanLyPhongMay
{
    public partial class FormThemPhong : Form
    {
        TablePhongMay phong;
        public FormThemPhong()
        {
            InitializeComponent();
            phong = new TablePhongMay();
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTen.Text))
            {
                MessageBox.Show("Tên phòng không được để trống");
                return;
            }
            PhongMay temp = new PhongMay();
            temp.ten = lblTen.Text;
            if (phong.POST(temp))
            {
                MessageBox.Show("Thêm thành công phòng " + temp.ten);
                this.Close();
            }
            else
                MessageBox.Show("Thêm không thành công phòng " + temp.ten);

        }
    }
}
