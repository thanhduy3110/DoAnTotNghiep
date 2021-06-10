using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOLoaiNV
    {
        private int ID;
        private string TenLoaiNV;
        private bool HieuLuc;

        public DTOLoaiNV(int iD, string tenLoaiNV, bool hieuLuc)
        {
            ID = iD;
            TenLoaiNV = tenLoaiNV;
            HieuLuc = hieuLuc;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string TenLoaiNV1 { get => TenLoaiNV; set => TenLoaiNV = value; }
        public bool HieuLuc1 { get => HieuLuc; set => HieuLuc = value; }
    }
}
