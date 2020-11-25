using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3_ThueCD
{
    class KhachHang
    {
        private int id;
        private String ten;
        private int soLuong;
        private double donGia;
        private bool dungHan;

        public KhachHang(int id, string ten, int soLuong, double donGia, bool dungHan)
        {
            this.id = id;
            this.ten = ten;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.dungHan = dungHan;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public bool DungHan { get => dungHan; set => dungHan = value; }

        public double ThanhTien()
        {
            return TongTien() - GiamGia();
        }

        public double GiamGia()
        {
            return dungHan ? TongTien() * -0.05 : TongTien() * 0.03;
        }

        private double TongTien()
        {
            return soLuong * donGia;
        }
    }
}
