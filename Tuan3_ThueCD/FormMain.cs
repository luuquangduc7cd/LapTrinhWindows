using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_ThueCD
{
    public partial class FormMain : Form
    {
        private DanhSach list;
        private int index = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            list = new DanhSach();
            LoadDataToListView();
        }

        private void LoadDataToListView()
        {
            lvw.Items.Clear();
            List<KhachHang> temp = list.ToList();
            foreach(KhachHang i in temp)
            {
                string[] row = { 
                                    i.Id.ToString(), 
                                    i.Ten, i.SoLuong.ToString(), 
                                    i.DonGia.ToString("#.###,##"), 
                                    i.GiamGia().ToString("#.###,##"), 
                                    i.ThanhTien().ToString("#.###,##") 
                                };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Tag = i;
                lvw.Items.Add(lvi);
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi");
            else
            {
                KhachHang kh = new KhachHang(int.Parse(txtMa.Text), txtTen.Text, int.Parse(cbxSoLuong.Text), double.Parse(txtDonGia.Text), radGiam.Checked);
                if(list.Them(kh))
                {
                    MessageBox.Show("Thêm thành công khách hàng", "Thêm");
                    LoadDataToListView();
                    ClearForm();
                }
                else
                    MessageBox.Show("Khách hàng đã tồn tại", "Lỗi");
            }
        }

        private void ClearForm()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDonGia.Clear();
            cbxSoLuong.Text = "0";
        }

        private bool KiemTraHopLe()
        {
            return !(String.IsNullOrEmpty(txtMa.Text) ||
                    String.IsNullOrEmpty(txtTen.Text) ||
                    String.IsNullOrEmpty(txtDonGia.Text) ||
                    String.IsNullOrEmpty(cbxSoLuong.Text) ||
                    (radGiam.Checked == radPhat.Checked));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số tiền thuê đĩa: " + list.TongTien().ToString("#.###,##"));
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw.SelectedItems.Count > 0)
            {
                index = lvw.SelectedIndices[0];
                KhachHang temp = (KhachHang)lvw.Items[index].Tag;
                LoadDataToForm(temp);
            }
            for (int i = 1; i < lvw.SelectedItems.Count; i++)
                lvw.SelectedItems[i].Selected = false;
        }

        private void LoadDataToForm(KhachHang temp)
        {
            txtMa.Text = temp.Id.ToString();
            txtTen.Text = temp.Ten;
            cbxSoLuong.Text = temp.SoLuong.ToString();
            txtDonGia.Text = temp.DonGia.ToString("#.###,##");
            radGiam.Checked = temp.DungHan;
            radPhat.Checked = !temp.DungHan;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMa.Text))
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    int id = int.Parse(txtMa.Text);
                    if (list.Xoa(id))
                    {
                        LoadDataToListView();
                        ClearForm();
                    }
                    else
                        MessageBox.Show("Khách hàng không tồn tại", "Lỗi");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi");
            else
            {
                KhachHang kh = new KhachHang(int.Parse(txtMa.Text), txtTen.Text, int.Parse(cbxSoLuong.Text), double.Parse(txtDonGia.Text), radGiam.Checked);
                if (list.CapNhat(kh))
                {
                    MessageBox.Show("Cập nhật thành công khách hàng " + kh.Ten, "Cập nhật");
                    ClearForm();
                    LoadDataToListView();
                }
                else
                    MessageBox.Show("Khách hàng không tồn tại", "Lỗi"); 
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMa.Text))
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
            else
            {
                int id = int.Parse(txtMa.Text);
                for(int i = 0; i < lvw.Items.Count; i++)
                {
                    KhachHang temp = (KhachHang) lvw.Items[i].Tag;
                    if(temp.Id == id)
                    {
                        index = i;
                        lvw.Items[i].Selected = true;
                        LoadDataToForm(temp);
                        return;
                    }
                }
                MessageBox.Show("Khách hàng không tồn tại", "Lỗi");
            }
        }
    }
}
