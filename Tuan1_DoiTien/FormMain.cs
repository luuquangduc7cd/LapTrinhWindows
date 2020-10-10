using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_DoiTien
{
    public partial class FormMain : Form
    {
        private const int VND_TO_USD = 23070;
        private const int VND_TO_EUR = 27968;
        public FormMain()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            return !string.IsNullOrEmpty(txtTien.Text);
        }

        private void btnVndToUsd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int vnd = int.Parse(txtTien.Text);
                double usd = 1.0 * vnd / VND_TO_USD;
                txtKetQua.Text = usd.ToString("#,###.##");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

        private void btnVndToEur_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int vnd = int.Parse(txtTien.Text);
                double eur = 1.0 * vnd / VND_TO_EUR;
                txtKetQua.Text = eur.ToString("#,###.##");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

        private void btnUsdToVnd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int usd = int.Parse(txtTien.Text);
                double vnd = 1.0 * usd * VND_TO_USD;
                txtKetQua.Text = vnd.ToString("#,###.##");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }

        private void btnEurToVnd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int eur = int.Parse(txtTien.Text);
                double vnd = 1.0 * eur * VND_TO_EUR;
                txtKetQua.Text = vnd.ToString("#,###.##");
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền cần quy đổi");
        }
    }
}
