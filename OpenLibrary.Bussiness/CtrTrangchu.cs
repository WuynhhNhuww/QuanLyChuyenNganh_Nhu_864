using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.Bussiness
{
    public class CtrTrangchu
    {
        public void logout()
        {
            LoginInfo.MaNV = -1;
            LoginInfo.HoTenNV = "";
            LoginInfo.CMND = "";
            LoginInfo.SDT = "";
            LoginInfo.DiaChi = "";
            LoginInfo.Email = "";
            LoginInfo.MaCN = -1;
            LoginInfo.UserName = "";
            LoginInfo.Password = "";
        }
    }
}
