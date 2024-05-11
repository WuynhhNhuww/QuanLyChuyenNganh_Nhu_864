using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.Bussiness
{
    public class CtrChuyenNganh
    {
        QLChuyenNganhDL cn = new QLChuyenNganhDL();
        public bool ThemtenchuyenNganh(String s)
        {

            try
            {
                cn.Themmoichuyennganh(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable laydschuyennganh()
        {
            return cn.Laychuyennganh();
        }
        public bool SuachuyenNganh(String tencn, String macn)
        {

            try
            {
                cn.Suachuyennganh(tencn, macn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaChuyenNganh(String s)
        {

            try
            {
                bool t = cn.XoaChuyenNganh(s);
                return t;
            }
            catch
            {
                return false;
            }
        }
    }
}
