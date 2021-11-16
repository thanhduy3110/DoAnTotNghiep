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

        public DataTable THongKePhongChoKhach()
        {
            return TK.THongKePhongChoKhach();
        }

        public DataTable ThongKePhongSuaChua()
        {
            return TK.ThongKePhongSuaChua();
        }

        public void ThongKeHD(DataGridView dgv, string dtp1, string dtp2)
        {
            TK.ThongKeHD(dgv, dtp1, dtp2);
        }
        public void ThongKeDV(DataGridView dgv, string dtp1, string dtp2)
        {
           TK.ThongKeDV(dgv, dtp1, dtp2);
        }
        public DataTable bieudo_select()
        {
            return TK.bieudo_select();
        }



    }
}

