using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUCVU
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_CHUCVU> getList()
        {
            return db.tb_CHUCVU.ToList();
        }

        public tb_CHUCVU getItem(int id)
        {
            var dt = db.tb_CHUCVU.FirstOrDefault(_ => _.IDCV == id);
            return dt;
        }

        public tb_CHUCVU Add(tb_CHUCVU item)
        {
            try
            {
                db.tb_CHUCVU.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_CHUCVU Edit(tb_CHUCVU item)
        {
            try
            {
                var dt = db.tb_CHUCVU.FirstOrDefault(_ => _.IDCV == item.IDCV);
                dt.TENCV = item.TENCV;
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
                var dt = db.tb_CHUCVU.FirstOrDefault(_ => _.IDCV == id);
                db.tb_CHUCVU.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
