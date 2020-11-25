using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    class TablePhongMay : KetNoi
    {
        private QuanLyPhongMayDataContext dt;
        public TablePhongMay()
        {
            dt = getKetNoi();
        }
        public IEnumerable<PhongMay> GET(string id)
        {
            IEnumerable<PhongMay> list = dt.PhongMays.Where(item => item.id.Equals(id));
            return list;
        }
        public IEnumerable<PhongMay> GetAll()
        {
            return dt.PhongMays;
        }

        public IEnumerable<MayTinh> GetMayTinhByPhongMay(int id)
        {
            IEnumerable<MayTinh> list = from item in dt.MayTinhs
                                        where item.idPhong.Equals(id)
                                        select item;
            return list;
        }
        public bool POST(PhongMay p)
        {
            try
            {
                dt.PhongMays.InsertOnSubmit(p);
                dt.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
