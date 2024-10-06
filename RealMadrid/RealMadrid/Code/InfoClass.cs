using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RealMadrid;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for AboutClass
    /// </summary>
    public class InfoClass
    {
        public static DataTable GetAll()
        {
            string strSQL = "SELECT * FROM [tblInfo]";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetInfo(string strType)
        {
            string strSQL = "SELECT * FROM [tblInfo] WHERE [MyType]='{0}'";
            strSQL = string.Format(strSQL, strType);
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetInfoByTEXT(string Data)
        {
            string strSQL = "SELECT * FROM [tblInfo] WHERE [MyData]='" + Data + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;

        }

        public static void DeleteInfo(string strType)
        {
            string strSQL = "DELETE * FROM [tblInfo] WHERE [MyType]='" + strType + "'";
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateInfo(string strType, string Data)
        {
            string strSQL = "UPDATE [tblInfo] SET [MyData]='{0}' WHERE [MyID]={1}";
            DataTable dt = GetInfo(strType);
            string strInfo = Data.Replace("'", "''");
            strSQL = string.Format(strSQL, strInfo, dt.Rows[0]["MyID"].ToString());
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertInfo(string strType, string Data)
        {
            string strSQL = "INSERT INTO [tblInfo] ([MyType],[MyData]) ";
            strSQL += "VALUES (";
            strSQL += "'{0}', '{1}'";
            strSQL += ")";
            string strInfo = Data.Replace("'", "''");
            strSQL = string.Format(strSQL, strType, strInfo);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}