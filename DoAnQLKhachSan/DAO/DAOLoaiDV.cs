using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOLoaiDV
    {
        dbConnectionData db = new dbConnectionData();

        string[] name = { };
        object[] value = { };

        public DataTable loaidv_select()
        {
            return db.Laydulieu("loaidv_select");
        }

        public int loaidv_them(string ID, string TenLoaiDV, string HieuLuc)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@TenLoaiDV"; value[1] = TenLoaiDV;
            name[2] = "@HieuLuc"; value[2] = HieuLuc;

            return db.ThucHien("loaidv_them", name, value, 3);
        }

        public int loaidv_capnhat(string ID, string TenLoaiDV, string HieuLuc)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@TenLoaiDV"; value[1] = TenLoaiDV;
            name[2] = "@HieuLuc"; value[2] = HieuLuc;

            return db.ThucHien("loaidv_capnhat", name, value, 3);
        }


    }
}
