using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHONGBAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_PHONGBAN> getList()
        {
            return db.tb_PHONGBAN.ToList();
        }

        public tb_PHONGBAN getItem(int id)
        {
            var dt = db.tb_PHONGBAN.FirstOrDefault(_ => _.IDPB == id);
            return dt;
        }

        public tb_PHONGBAN Add(tb_PHONGBAN item)
        {
            try
            {
                db.tb_PHONGBAN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_PHONGBAN Edit(tb_PHONGBAN item)
        {
            try
            {
                var dt = db.tb_PHONGBAN.FirstOrDefault(_ => _.IDPB == item.IDPB);
                dt.TENPB = item.TENPB;
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
                var dt = db.tb_PHONGBAN.FirstOrDefault(_ => _.IDPB == id);
                db.tb_PHONGBAN.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
