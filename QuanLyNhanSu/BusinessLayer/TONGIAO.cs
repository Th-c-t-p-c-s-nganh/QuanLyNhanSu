using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TONGIAO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_TONGIAO> getList()
        {
            return db.tb_TONGIAO.ToList();
        }

        public tb_TONGIAO getItem(int id)
        {
            var dt = db.tb_TONGIAO.FirstOrDefault(_ => _.IDTG == id);
            return dt;
        }

        public tb_TONGIAO Add(tb_TONGIAO item)
        {
            try
            {
                db.tb_TONGIAO.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_TONGIAO Edit(tb_TONGIAO item)
        {
            try
            {
                var dt = db.tb_TONGIAO.FirstOrDefault(_ => _.IDTG == item.IDTG);
                dt.TENTG = item.TENTG;
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
                var dt = db.tb_TONGIAO.FirstOrDefault(_ => _.IDTG == id);
                db.tb_TONGIAO.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
