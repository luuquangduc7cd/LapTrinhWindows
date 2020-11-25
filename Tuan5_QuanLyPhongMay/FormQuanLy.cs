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
    public partial class frmMain : Form
    {
        private TableMayTinh tblMayTinh;
        private TablePhongMay tblPhongMay;
        private IEnumerable<PhongMay> list;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            Init();
        }

        private void Init()
        {
            tblMayTinh = new TableMayTinh();
            tblPhongMay = new TablePhongMay();
            list = tblPhongMay.GetAll();
            LoadDataToTree(tblPhongMay);
        }

        private void LoadDataToTree(TablePhongMay tblPhongMay)
        {
            IEnumerable<PhongMay> list = tblPhongMay.GetAll();
            foreach (PhongMay i in list)
            {
                TreeNode root = new TreeNode(i.ten);
                root.Name = i.id.ToString();
                tree.Nodes.Add(root);
                IEnumerable<MayTinh> mts = tblPhongMay.GetMayTinhByPhongMay(i.id);
                LoadMayTinhToTree(root, mts);
            }
        }

        private void LoadMayTinhToTree(TreeNode root, IEnumerable<MayTinh> mts)
        {
            foreach (MayTinh mt in mts)
            {
                TreeNode node = new TreeNode(mt.id);
                node.Tag = mt;
                root.Nodes.Add(node);
            }
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = tree.SelectedNode;
            int level = node.Level;
            if(level == 0)
            {
                int id = int.Parse(node.Name);
                IEnumerable<MayTinh> mts = tblPhongMay.GetMayTinhByPhongMay(id);
                LoadMayTinhToListView(mts);
            }
            else if(level == 1)
            {
                int idphong = int.Parse(node.Parent.Name);
                PhongMay pm = getPhong(idphong);
                MayTinh mt = (MayTinh)node.Tag;
                IEnumerable<MayTinh> list = tblPhongMay.GetMayTinhByPhongMay(pm.id);
                LoadMayTinhToListView(list);
                FocusListView(mt);
                
            }
        }

        private void FocusListView(MayTinh mt)
        {
            foreach(ListViewItem i in lvw.Items)
                if(i.Name.Equals(mt.id))
                {
                    i.Selected = true;
                    LoadMayTinhToForm(mt);
                    return;
                }
        }

        private void LoadMayTinhToForm(MayTinh mt)
        {
            txtID.Text = mt.id;
            txtCpu.Text = mt.cpu;
            txtHdd.Text = mt.hdd;
            txtRam.Text = mt.ram;
            txtVga.Text = mt.vga;
            txtMonitor.Text = mt.monitor;
            int id = int.Parse(mt.idPhong.ToString());
            txtPhong.Text = getPhong(id).ten;
        }

        private void LoadMayTinhToListView(IEnumerable<MayTinh> mts)
        {
            lvw.Items.Clear();
            foreach(MayTinh mt in mts)
            {
                string[] row = { mt.id, mt.cpu, mt.hdd, mt.ram, mt.vga, mt.monitor };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Name = mt.id;
                lvw.Items.Add(lvi);
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvw.SelectedItems.Count > 0)
            {
                string id = lvw.Items[lvw.SelectedIndices[0]].Name;
                MayTinh mt = tblMayTinh.GET(id).First();
                LoadMayTinhToForm(mt);
                for (int i = 1; i < lvw.SelectedItems.Count; i++)
                    lvw.SelectedItems[i].Selected = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = -1;
            if (isValidData())
            {
                MayTinh mt = new MayTinh();
                mt.id = txtID.Text;
                mt.cpu = txtCpu.Text;
                mt.ram = txtRam.Text;
                mt.vga = txtVga.Text;
                mt.monitor = txtMonitor.Text;
                mt.hdd = txtHdd.Text;
                mt.idPhong = getIdPhong(list, txtPhong.Text);
                if (mt.idPhong >= 0)
                    result = tblMayTinh.POST(mt);
                if(result == -1)
                    MessageBox.Show("Không tìm thấy phòng hợp lệ!");
                else if(result == 0)
                    MessageBox.Show("Thông tin máy đã tồn tại!");
                else
                {
                    MessageBox.Show("Thêm thành công!");
                    ReloadAll();
                }
            }
        }

        private void ReloadAll()
        {
            tree.Nodes.Clear();
            lvw.Items.Clear();
            Init();
        }

        private int getIdPhong(IEnumerable<PhongMay> list, string text)
        {
            string temp = text.Trim().ToLower();
            foreach (PhongMay i in list)
                if (i.ten.Trim().ToLower().Equals(temp.Trim().ToLower()))
                    return i.id;
            return -1;
        }
        private PhongMay getPhong(int id)
        {
            foreach (PhongMay i in list)
                if (id == i.id)
                    return i;
            return null;
        }

        private bool isValidData()
        {
            return !string.IsNullOrEmpty(txtID.Text) &&
                    !string.IsNullOrEmpty(txtCpu.Text) &&
                    !string.IsNullOrEmpty(txtHdd.Text) &&
                    !string.IsNullOrEmpty(txtRam.Text) &&
                    !string.IsNullOrEmpty(txtVga.Text) &&
                    !string.IsNullOrEmpty(txtMonitor.Text) &&
                    !string.IsNullOrEmpty(txtPhong.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không?", "Xóa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;
            int result = tblMayTinh.DELETE(txtID.Text);
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công");
                ReloadAll();
            }
            else if(result < 0)
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            else
                MessageBox.Show("Thông tin máy tính không tồn tại");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int result = -1;
            if (isValidData())
            {
                MayTinh mt = new MayTinh();
                mt.id = txtID.Text;
                mt.cpu = txtCpu.Text;
                mt.ram = txtRam.Text;
                mt.vga = txtVga.Text;
                mt.monitor = txtMonitor.Text;
                mt.hdd = txtHdd.Text;
                mt.idPhong = getIdPhong(list, txtPhong.Text);
                if (mt.idPhong > 0)
                    result = tblMayTinh.PUT(mt);
                if (result == -1)
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
                else if (result == 0)
                    MessageBox.Show("Thông tin máy không tồn tại!");
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                    ReloadAll();
                }
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            FormThemPhong frm = new FormThemPhong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            ReloadAll();
        }
    }
}
