using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BOPHAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_BOPHAN> getList()
        {
            return db.tb_BOPHAN.ToList();
        }

        public tb_BOPHAN getItem(int id)
        {
            var dt = db.tb_BOPHAN.FirstOrDefault(_ => _.IDBP == id);
            return dt;
        }

        public tb_BOPHAN Add(tb_BOPHAN item)
        {
            try
            {
                db.tb_BOPHAN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_BOPHAN Edit(tb_BOPHAN item)
        {
            try
            {
                var dt = db.tb_BOPHAN.FirstOrDefault(_ => _.IDBP == item.IDBP);
                dt.TENBP = item.TENBP;
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
                var dt = db.tb_BOPHAN.FirstOrDefault(_ => _.IDBP == id);
                db.tb_BOPHAN.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
