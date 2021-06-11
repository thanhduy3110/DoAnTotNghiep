using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOPhong
    {
        DataSet dsLoaiPhong = new DataSet();
        dbConnectionData db = new dbConnectionData();

        //Lấy danh sách ID và TenLoaiPhong gán vào combobox cbTenLP
        public void HienThiLoaiPhong(ComboBox cboTenLP)
        {
            dsLoaiPhong = db.LayDanhSach("select ID, TenLoaiPhong from LoaiPhong");// truy vấn lên sql
            cboTenLP.DataSource = dsLoaiPhong.Tables[0];
            cboTenLP.DisplayMember = "tenloaiphong";
            cboTenLP.ValueMember = "id";
        }

        public DataTable phong_select()
        {
            return db.Laydulieu("phong_select");
        }


    }
}
