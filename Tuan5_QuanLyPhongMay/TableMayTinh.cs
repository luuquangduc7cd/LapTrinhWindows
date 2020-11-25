using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    class TableMayTinh : KetNoi
    {
        private QuanLyPhongMayDataContext dt;
        public TableMayTinh()
        {
            dt = getKetNoi();
        }

        private bool isExist(string id)
        {
            IEnumerable<MayTinh> mts = dt.MayTinhs.Where(item => item.id == id);
            return mts != null;
        }

        public IEnumerable<MayTinh> GET(string id)
        {
            IEnumerable<MayTinh> list = from item in dt.MayTinhs
                                        where item.id.Equals(id)
                                        select item;
            return list;
        }

        public IEnumerable<MayTinh> GetAll()
        {
            IEnumerable<MayTinh> list = from i in dt.MayTinhs select i;
            return list;
        }
        public int POST(MayTinh mt)
        {
            //System.Data.Common.DbTransaction transaction = dt.Connection.BeginTransaction();
            try
            {
                //dt.Transaction = transaction;
                
                dt.MayTinhs.InsertOnSubmit(mt);
                dt.SubmitChanges();
                //dt.Transaction.Commit();
                return 1;
            }
            catch(Exception e)
            {
                //dt.Transaction.Rollback();
                return -1;
            }
        }
        public int PUT(MayTinh mt)
        {
            try
            {
                IQueryable<MayTinh> item = from i in dt.MayTinhs
                                           where i.id.Equals(mt.id)
                                           select i;
                item.First().cpu = mt.cpu;
                item.First().hdd = mt.hdd;
                item.First().ram = mt.ram;
                item.First().vga = mt.vga;
                item.First().monitor = mt.monitor;
                item.First().idPhong = mt.idPhong;
                dt.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int DELETE(string id)
        {
            try
            {
                MayTinh mt = dt.MayTinhs.Where(item => item.id == id).FirstOrDefault();
                dt.MayTinhs.DeleteOnSubmit(mt);
                dt.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
