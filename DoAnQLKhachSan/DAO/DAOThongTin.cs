using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOThongTin
    {
        DataSet dsNhanVien = new DataSet();
        dbConnectionData db = new dbConnectionData();

        //Lấy danh sách ID và TenLoaiNV gán vào combobox cbTenLoaiNV
        public void HienThiThongTin(ComboBox cboTenLoaiNV)
        {
            dsNhanVien = db.LayDanhSach("select ID, TenLoaiNV from LoaiNV where HieuLuc=1");// truy vấn lên sql
            cboTenLoaiNV.DataSource = dsNhanVien.Tables[0];
            cboTenLoaiNV.DisplayMember = "tenloainv";
            cboTenLoaiNV.ValueMember = "id";
        }
    }
}
