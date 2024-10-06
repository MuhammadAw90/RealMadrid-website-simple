using System;
using System.Data;
using System.Web;
using System.Data.OleDb;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for Dbase
    /// </summary>
    public class Dbase
    {
        public static OleDbConnection MakeConnection(string dbFile)
        {
            OleDbConnection c = new OleDbConnection();
            c.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/" + dbFile);
            c.Open();
            return c;
        }

        public static DataTable SelectFromTable(string strSql, string FileName)
        {
            OleDbConnection c = MakeConnection(FileName);
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSql;
            comm.Connection = c;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(comm);
            da.Fill(dt);
            c.Close();
            return dt;
        }

        public static void ChangeTable(string strSql, string FileName)
        {
            OleDbConnection c = MakeConnection(FileName);
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSql;
            comm.Connection = c;
            comm.ExecuteNonQuery();
            c.Close();

        }
        public static Object ExecuteScalar(string strSQL, string strFileName)
        {
            OleDbConnection c = MakeConnection(strFileName);
            OleDbCommand cmd = new OleDbCommand(strSQL, c);
            Object val = new Object();
            val = null;
            val = cmd.ExecuteScalar();
            c.Close();
            return val;
        }

    }
}