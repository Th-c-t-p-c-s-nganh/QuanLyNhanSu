using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.ToList();
        }

        public List<NHANVIEN_DTO> getFullList()
        {
            var lstNv = db.tb_NHANVIEN.ToList();
            List<NHANVIEN_DTO> list = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO _dto;
            foreach(var item in lstNv)
            {
                _dto = new NHANVIEN_DTO();
                _dto.MANV = item.MANV;
                _dto.HOTEN = item.HOTEN;
                _dto.NGAYSINH = item.NGAYSINH;
                _dto.DIACHI = item.DIACHI;
                _dto.DIENTHOAI = item.DIENTHOAI;
                _dto.CCCD = item.CCCD;
                _dto.HINHANH = item.HINHANH;

                _dto.IDBP = item.IDBP;
                var bp = db.tb_BOPHAN.FirstOrDefault(_ => _.IDBP == item.IDBP);
                _dto.TENBP = bp.TENBP;

                _dto.IDPB = item.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(_ => _.IDPB == item.IDPB);
                _dto.TENPB = pb.TENPB;

                _dto.IDCT = item.IDCT;
                var ct = db.tb_CONGTY.FirstOrDefault(_ => _.IDCT == item.IDCT);
                _dto.TENCT = ct.TENCTY;

                _dto.IDCV = item.IDCV;
                var cv = db.tb_CHUCVU.FirstOrDefault(_ => _.IDCV == item.IDCV);
                _dto.TENCV = cv.TENCV;

                _dto.IDDT = item.IDDT;
                var dt = db.tb_DANTOC.FirstOrDefault(_ => _.IDDT == item.IDDT);
                _dto.TENDT = dt.TENDT;

                _dto.IDTG = item.IDTG;
                var tg = db.tb_TONGIAO.FirstOrDefault(_ => _.IDTG == item.IDTG);
                _dto.TENTG = tg.TENTG;

                _dto.IDTD = item.IDTD;
                var td = db.tb_TRINHDO.FirstOrDefault(_ => _.IDTD == item.IDTD);
                _dto.TENTD = td.TENTD;

                list.Add(_dto);
            }

            return list;
        }

        public tb_NHANVIEN getItem(int id)
        {
            var dt = db.tb_NHANVIEN.FirstOrDefault(_ => _.MANV == id);
            return dt;
        }

        public tb_NHANVIEN Add(tb_NHANVIEN item)
        {
            try
            {
                db.tb_NHANVIEN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public tb_NHANVIEN Edit(tb_NHANVIEN item)
        {
            try
            {
                var dt = db.tb_NHANVIEN.FirstOrDefault(_ => _.MANV == item.MANV);
                dt.HOTEN = item.HOTEN;
                dt.CCCD = item.CCCD;
                dt.DIACHI = item.DIACHI;
                dt.DIENTHOAI = item.DIENTHOAI;
                dt.IDTG = item.IDTG;
                dt.IDCT = 0;
                dt.IDCV = item.IDCV;
                dt.IDTG = item.IDTG;
                dt.IDDT = item.IDDT;
                dt.IDPB = item.IDPB;
                dt.IDBP = item.IDBP;
                dt.HINHANH = item.HINHANH;
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
                var dt = db.tb_NHANVIEN.FirstOrDefault(_ => _.MANV == id);
                db.tb_NHANVIEN.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
