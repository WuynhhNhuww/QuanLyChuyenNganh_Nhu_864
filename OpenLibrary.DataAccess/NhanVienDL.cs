using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class NhanVienDL
    {
        DataTable NhanVien;
        DataHelper dt = DataHelper.GetInstance();
        public NhanVienDL()
        {
            NhanVien = dt.FillDataTable("Select * from NHANVIEN");
        }
        public DataTable LayNhanVien()
        {
            return NhanVien;
        }

        public DataRow[] TimNhanVien(string userName, string password)
        {
            DataRow[] nv = NhanVien.Select("UserName = '" + userName + " 'AND Password='" + password + " ' ");
            return nv;
        }
    }
}
