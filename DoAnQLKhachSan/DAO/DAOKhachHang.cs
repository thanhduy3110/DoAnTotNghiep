using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DAOKhachHang
    {
        dbConnectionData db = new dbConnectionData();

        string[] name = { };
        object[] value = { };

        public DataTable khachhang_select()
        {
            return db.Laydulieu("khachhang_select");
        }

        public int khachhang_them(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, string GioiTinh, string QuocTich, string HieuLuc)
        {
            name = new string[9];
            value = new object[9];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@NgaySinh"; value[2] = NgaySinh;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@Email"; value[4] = Email;
            name[5] = "@CMND"; value[5] = CMND;
            name[6] = "@GioiTinh"; value[6] = GioiTinh;
            name[7] = "@QuocTich"; value[7] = QuocTich;
            name[8] = "@HieuLuc"; value[8] = HieuLuc;

            return db.ThucHien("khachhang_them", name, value, 9);

        }

        public int khachang_capnhat(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, string GioiTinh, string QuocTich, string HieuLuc)
        {
            name = new string[9];
            value = new object[9];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@NgaySinh"; value[2] = NgaySinh;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@Email"; value[4] = Email;
            name[5] = "@CMND"; value[5] = CMND;
            name[6] = "@GioiTinh"; value[6] = GioiTinh;
            name[7] = "@QuocTich"; value[7] = QuocTich;
            name[8] = "@HieuLuc"; value[8] = HieuLuc;

            return db.ThucHien("khachang_capnhat", name, value, 9);

        }



    }
}
