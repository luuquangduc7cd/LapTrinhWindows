using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    public class KetNoi
    {
        private string strKetNoi = @"Data Source=localhost;Initial Catalog=QuanLyPhongMay;Persist Security Info=True;User ID=sa;Password=sysadminpwd";
        protected QuanLyPhongMayDataContext getKetNoi()
        {
            QuanLyPhongMayDataContext dt = new QuanLyPhongMayDataContext(strKetNoi);
            dt.Connection.Open();
            return dt;
        }
    }
}
