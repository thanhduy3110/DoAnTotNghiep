using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSPhong
    {

            DAOPhong NV = new DAOPhong();
        public void HienThiLP(ComboBox cboTenLP)
        {
                NV.HienThiLoaiPhong(cboTenLP);
        }

        public DataTable Phong_Select()
        {
            return NV.phong_select();
        }
    }
}
