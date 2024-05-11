using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class QLChuyenNganhDL
    {
        DataTable tblChuyenNganh;
        DataHelper dt = DataHelper.GetInstance();
        public QLChuyenNganhDL()
        {
            tblChuyenNganh = dt.FillDataTable("SELECT * FROM ChuyenNganh");
        }
        public DataTable Laychuyennganh()
        {
            tblChuyenNganh = dt.FillDataTable("SELECT * FROM ChuyenNganh");
            return tblChuyenNganh;
        }
        public bool Themmoichuyennganh(String tencn)
        {
            try
            {
                dt.InsertRowtable(tblChuyenNganh, null, tencn);
                dt.UpdateFromDataTableToDataBase("ChuyenNganh", tblChuyenNganh);
                return true;
            }
            catch
            {

                return false;

            }
        }
        public bool XoaChuyenNganh(String macn)
        {
            try
            {
                dt.DeleteRowTable(tblChuyenNganh, "MaCN = " + macn);
                dt.UpdateFromDataTableToDataBase("[dbo].[CHUYENNGANH]", tblChuyenNganh);
                return true;
            }
            catch
            {

                return false;

            }
        }
        public bool Suachuyennganh(String tencn, String macn)
        {
            try
            {
                String dk = " MaCN = " + macn;

                dt.UpdateRowTable(tblChuyenNganh, dk, "TenCN", tencn);

                dt.UpdateFromDataTableToDataBase("ChuyenNganh", tblChuyenNganh);
                return true;
            }
            catch
            {

                return false;

            }
        }

    }
}