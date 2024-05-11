using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class DataHelper
    {
        private static DataHelper dt = null;
        DataSet DS = new DataSet();
        static string ChuoiKetNoi;
        SqlConnection con;
        private DataHelper()
        {
            ChuoiKetNoi = "Data Source=DESKTOP-958RILU;Initial Catalog=OPENLIBRARY;Integrated Security=True";
            con = new SqlConnection(ChuoiKetNoi);
        }
        public static DataHelper GetInstance()
        {
            if (dt == null)
                dt = new DataHelper();
            return dt;
        }
        public DataTable FillDataTable(string strSQL)
        {
            SqlDataAdapter DA = new SqlDataAdapter(strSQL, ChuoiKetNoi);
            DataTable dt = new DataTable();
            DA.FillSchema(dt, SchemaType.Mapped);
            DA.Fill(dt);
            return dt;

        }

        public void UpdateFromDataTableToDataBase(string tenBangDB, DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from " + tenBangDB, ChuoiKetNoi);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                dt.RejectChanges();
                throw new Exception(ex.Message);
            }
        }
        public void InsertRowtable(DataTable dt, params object[] Value)
        {
            DataRow dr = dt.NewRow();
            try
            {
                for (int i = 0; i < Value.Length; i++)
                {
                    if (Value[i] != null)
                        dr[i] = Value[i];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            dt.Rows.Add(dr);
        }

        public Boolean DeleteRowTable(DataTable dt, string dieukien)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = dieukien;
                dv.AllowDelete = true;
                int i = 0;
                bool kt = false;
                while (i < dv.ToTable().Rows.Count)
                {
                    dv[i].Delete();
                    kt = true;
                }
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateRowTable(DataTable dt, string dieukien, params object[] field_GiaTri)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = dieukien;
            for (int i = 0; i < dv.ToTable().Rows.Count; i++)
            {
                for (int j = 0; j < field_GiaTri.Length; j += 2)
                {
                    dv[i][field_GiaTri[j].ToString()] = field_GiaTri[j + 1];
                }
            }
        }
    }
}
