using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSLoaiNV
    {
        //public static DataTable GetAllLoaiNV()
        //{
        //    return DAOLoaiNV.getData();
        //}

        //public static void InsertLoaiNV(DTOLoaiNV LoaiNV)
        //{
        //    DAOLoaiNV.InsertLoaiNV(LoaiNV);
        //}

        //public static void UpdateLoaiNV(DTOLoaiNV LoaiNV)
        //{
        //    DAOLoaiNV.UpdateLoaiNV(LoaiNV);
        //}

        //loại phòng
        DAOLoaiNV LNV = new DAOLoaiNV();

        //Loại nhân viên ở DAO
        public DataTable LoaiNV_selecl()
        {
            return LNV.LoaiNV_Select();
        }
        public int LoaiNV_Them(int ID, string TenLoaiNV, int HieuLuc)
        {
            return LNV.LoaiNV_Them(ID, TenLoaiNV, HieuLuc);
        }
        public int LoaiNV_CapNhat(int ID, string TenLoaiNV, int HieuLuc)
        {
            return LNV.LoaiNV_CapNhat(ID, TenLoaiNV, HieuLuc);
        }

        public int LoaiNV_Xoa(int ID, int HieuLuc)
        {
            return LNV.LoaiNV_Xoa(ID,  HieuLuc);
        }
    }
}
