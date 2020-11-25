using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan4_Cinema
{
    public partial class FormMain : Form
    {
        private const int DAY_A = 100, DAY_B = 200, DAY_C = 300, DAY_D = 400;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            txtThanhTien.Text = tinhTien().ToString("#,###.##");
            foreach (Button btn in pnlFlow.Controls)
                if (btn.BackColor == Color.Wheat)
                {
                    btn.BackColor = Color.GreenYellow;
                    btn.Enabled = false;
                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in pnlFlow.Controls)
                btn.BackColor = (btn.BackColor == Color.Wheat) ? Color.White : btn.BackColor;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = (btn.BackColor == Color.White) ? Color.Wheat : Color.White;
            txtThanhTien.Text = tinhTien().ToString("#,###.##");
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (Button btn in pnlFlow.Controls)
                if (btn.BackColor == Color.GreenYellow)
                {
                    int vitri = int.Parse(btn.Text);
                    if (vitri <= 10)
                        tong += DAY_A;
                    else if (vitri <= 20)
                        tong += DAY_B;
                    else if (vitri <= 30)
                        tong += DAY_C;
                    else if (vitri <= 40)
                        tong += DAY_D;
                    else
                        tong += 0;
                }
            txtThanhTien.Text = tong.ToString("#,###.##");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            e.Cancel = dr == DialogResult.No;
        }

        private int tinhTien()
        {
            int tong = 0;
            foreach(Button btn in pnlFlow.Controls)
                if(btn.BackColor == Color.Wheat)
                {
                    int vitri = int.Parse(btn.Text);
                    if (vitri <= 10)
                        tong += DAY_A;
                    else if (vitri <= 20)
                        tong += DAY_B;
                    else if (vitri <= 30)
                        tong += DAY_C;
                    else if (vitri <= 40)
                        tong += DAY_D;
                    else
                        tong += 0;
                }
            return tong;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            for(int i = 1; i <= 40; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.FlatStyle = FlatStyle.Flat;
                btn.Width = btn.Height = 75;
                btn.BackColor = Color.White;
                btn.Click += new EventHandler(btnItem_Click);
                pnlFlow.Controls.Add(btn);
            }
        }
    }
}
