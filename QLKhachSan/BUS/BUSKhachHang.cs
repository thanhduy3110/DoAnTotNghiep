﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUSKhachHang
    {
        DAOKhachHang kh = new DAOKhachHang();

        public DataTable KH_Select()
        {
            return kh.khachhang_select();
        }

        public int KH_Them(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, string GioiTinh, string QuocTich, string HieuLuc)
        {
            return kh.khachhang_them(ID, HoTen, NgaySinh, SDT, Email, CMND, GioiTinh, QuocTich, HieuLuc);
        }

        public int KH_CapNhat(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, string GioiTinh, string QuocTich, string HieuLuc)
        {
            return kh.khachang_capnhat(ID, HoTen, NgaySinh, SDT, Email, CMND, GioiTinh, QuocTich, HieuLuc);
        }
    }
}
