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

       

        public DataSet ThongKeSLT()
        {
            return TK.ThongKeSLT();
        }

        public DataSet ThongKeHD()
        {
            return TK.ThongKeHD();
        }
        public DataTable bieudo_select()
        {
            return TK.bieudo_select();
        }

    }
}

