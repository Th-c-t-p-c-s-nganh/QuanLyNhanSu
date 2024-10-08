using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_DANTOC> getList()
        {
            return db.tb_DANTOC.ToList();
        }

        public tb_DANTOC getItem(int id)
        {
            var dt = db.tb_DANTOC.FirstOrDefault(_ => _.IDDT == id);
            return dt;
        }

        public tb_DANTOC Add(tb_DANTOC item)
        {
            try
            {
                db.tb_DANTOC.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_DANTOC Edit(tb_DANTOC item)
        {
            try
            {
                var dt = db.tb_DANTOC.FirstOrDefault(_ => _.IDDT == item.IDDT);
                dt.TENDT = item.TENDT;
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
                var dt = db.tb_DANTOC.FirstOrDefault(_ => _.IDDT == id);
                db.tb_DANTOC.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

    }
}