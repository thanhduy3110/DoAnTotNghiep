using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAO
{
    public class DAOThongKe
    {
        DataSet dsThongKe = new DataSet();
        dbConnectionData db = new dbConnectionData();
        string[] name = { };
        object[] value = { };

        public DataTable bieudo_select()
        {
            return db.Laydulieu("bieudo_select");
        }

        public DataTable ThongKeSLT()
        {
            return  db.Laydulieu("ThongKeHD");
        }

        public DataTable ThongKeHD()
        {
            return  db.Laydulieu("ThongKeSLT");
        }

        public DataTable ThongKeDV()
        {
            return db.Laydulieu("ThongKeDV");
        }
    }
}
