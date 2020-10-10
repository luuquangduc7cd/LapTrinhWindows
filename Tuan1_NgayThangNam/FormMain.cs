using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_NgayThangNam
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtBirthday.Text))
            {
                msg += "Xin chào ";
                msg += txtName.Text;
                msg += "\n";
                msg += "Bạn sinh ngày: ";
                msg += txtBirthday.Text;
                MessageBox.Show(msg);
            }
            else
                MessageBox.Show("Không được để trống dữ liệu");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBirthday.Clear();
            txtName.Clear();
        }
    }
}
