using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGTY
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_CONGTY> getList()
        {
            return db.tb_CONGTY.ToList();
        }

        public tb_CONGTY getItem(int id)
        {
            var dt = db.tb_CONGTY.FirstOrDefault(_ => _.IDCT == id);
            return dt;
        }

        public tb_CONGTY Add(tb_CONGTY item)
        {
            try
            {
                db.tb_CONGTY.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_CONGTY Edit(tb_CONGTY item)
        {
            try
            {
                var dt = db.tb_CONGTY.FirstOrDefault(_ => _.IDCT == item.IDCT);
                dt.TENCTY = item.TENCTY;
                dt.DIACHI = item.DIACHI;
                dt.DIENTHOAI = item.DIENTHOAI;
                dt.EMAIL = item.EMAIL;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var dt = db.tb_CONGTY.FirstOrDefault(_ => _.IDCT == id);
                db.tb_CONGTY.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
