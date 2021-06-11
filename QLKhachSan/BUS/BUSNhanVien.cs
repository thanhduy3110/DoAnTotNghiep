using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSNhanVien
    {
        DAONhanVien NV = new DAONhanVien();
        public void HienThiTenLoaiNV(ComboBox cboTenLoaiNV)
        {
            NV.HienThiTenLoaiNV(cboTenLoaiNV);
        }
    }
}
