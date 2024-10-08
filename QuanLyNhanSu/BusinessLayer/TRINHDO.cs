using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }

        public tb_TRINHDO getItem(int id)
        {
            var dt = db.tb_TRINHDO.FirstOrDefault(_ => _.IDTD == id);
            return dt;
        }

        public tb_TRINHDO Add(tb_TRINHDO item)
        {
            try
            {
                db.tb_TRINHDO.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_TRINHDO Edit(tb_TRINHDO item)
        {
            try
            {
                var dt = db.tb_TRINHDO.FirstOrDefault(_ => _.IDTD == item.IDTD);
                dt.TENTD = item.TENTD;
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
                var dt = db.tb_TRINHDO.FirstOrDefault(_ => _.IDTD == id);
                db.tb_TRINHDO.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
