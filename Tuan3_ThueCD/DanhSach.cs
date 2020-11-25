using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3_ThueCD
{
    class DanhSach
    {
        List<KhachHang> list;

        public DanhSach()
        {
            list = new List<KhachHang>();
            list.Add(new KhachHang(1, "Lưu Quang Đức", 10, 15000, true));
            list.Add(new KhachHang(2, "Lưu Đức Quang", 15, 15000, false));
            list.Add(new KhachHang(3, "Đức Lưu Quang", 5, 20000, true));
            list.Add(new KhachHang(4, "Đức Quang Lưu", 30, 10000, false));
        }

        public List<KhachHang> ToList()
        {
            return list;
        }

        public bool Them(KhachHang kh)
        {
            foreach (KhachHang i in list)
                if (i.Id == kh.Id)
                    return false;
            list.Add(kh);
            return true;
        }
        public bool Xoa(int id)
        {
            foreach (KhachHang i in list)
                if (i.Id == id)
                {
                    list.Remove(i);
                    return true;
                }
            return false;
        }
        public bool CapNhat(KhachHang kh)
        {
            foreach (KhachHang i in list)
                if (i.Id == kh.Id)
                {
                    i.Ten = kh.Ten;
                    i.SoLuong = kh.SoLuong;
                    i.DonGia = kh.DonGia;
                    i.DungHan = kh.DungHan;
                    return true;
                }
            return false;
        }
        public KhachHang TimKiem(int id)
        {
            foreach (KhachHang i in list)
                if (i.Id == id)
                    return i;
            return null;
        }

        public double TongTien()
        {
            double tien = 0;
            foreach (KhachHang i in list)
                tien += i.ThanhTien();
            return tien;
        }
    }
}
