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
    public class BUSLogin
    {
        DAOLogin LG = new DAOLogin();

        public DataTable DangNhap_Select(string MaTK, string MatKhau)
        {
            return LG.DangNhap_Select(MaTK, MatKhau);
        }
    }
}
