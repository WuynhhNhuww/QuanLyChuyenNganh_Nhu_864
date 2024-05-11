using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenLibrary.DataAccess;
namespace OpenLibrary.Bussiness
{
    public class CtrLogin
    {
        public class CtrDangNhap
        {
            NhanVienDL nv = new NhanVienDL();
            public bool login(string userName, string password)
            {
                DataRow[] user = nv.TimNhanVien(userName, password);
                if (user.Length > 0)
                {
                    LoginInfo.MaNV = (int)user[0]["MaNV"];
                    LoginInfo.HoTenNV = user[0]["HoTenNV"].ToString();
                    LoginInfo.SDT = user[0]["SDT"].ToString();
                    LoginInfo.DiaChi = user[0]["DiaChi"].ToString();
                    LoginInfo.Email = user[0]["Email"].ToString();
                    LoginInfo.HinhAnh = user[0]["HinhAnh"].ToString();
                    LoginInfo.MaCN = (user[0]["MaCN"] != DBNull.Value) ? (int)user[0]["MaCN"] : -1;
                    LoginInfo.MaLoaiNV = (int)user[0]["MaLoaiNV"];
                    LoginInfo.UserName = user[0]["UserName"].ToString();
                    LoginInfo.Password = user[0]["Password"].ToString();
                    return true;
                }
                return false;
            }
        }
    }
}
