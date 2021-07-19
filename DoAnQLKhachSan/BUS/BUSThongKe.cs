using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAO;

namespace BUS
{
    public class BUSThongKe
    {
        DAOThongKe TK = new DAOThongKe();

        public DataSet ThongKeTheoNgay(string NgayBD, string NgayKT)
        {
             return TK.ThongKeTheoNgay(NgayBD, NgayKT);
        }

        public DataSet ThongKeDV(string NgayBD, string NgayKT)
        {
            return TK.ThongKeDV(NgayBD, NgayKT);
        }

        public DataSet ThongKeSLT()
        {
            return TK.ThongKeSLT();
        }
    }
}

