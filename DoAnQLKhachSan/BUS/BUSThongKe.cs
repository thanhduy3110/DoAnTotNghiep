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

       

        public DataTable ThongKeSLT()
        {
            return TK.ThongKeSLT();
        }

        public DataTable ThongKeHD()
        {
            return TK.ThongKeHD();
        }
        public DataTable ThongKeDV()
        {
            return TK.ThongKeDV();
        }
        public DataTable bieudo_select()
        {
            return TK.bieudo_select();
        }



    }
}

