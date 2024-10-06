using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using RealMadrid;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for NewsClass
    /// </summary>
    public class NewsClass
    {
        public static DataTable GetAll()
        {
            string strSQL = "SELECT * FROM tblNews ORDER BY [MyID] DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable LatestNews()
        {
            string strSQL = "SELECT TOP 3 * FROM tblNews ORDER BY [MyID] DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetNewByID(string strID)
        {
            string strSQL = "SELECT * FROM [tblNews] WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void DeleteNew(string strID)
        {
            string strSQL = "DELETE * FROM [tblNews] WHERE MyID=" + strID;
            Dbase.SelectFromTable(strSQL, "db.accdb");
        }

        public static void UpdateImage(string strID, string Img)
        {
            string strSQL = "UPDATE [tblCups] SET [MyImg]='{0}' WHERE [MyID]={1}";
            strSQL = string.Format(strSQL, Img, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateNew(string strID, string strTitle, string Body)
        {
            string strSQL = "UPDATE tblNews SET ";
            strSQL += "[MyTitle]='{0}', [MyBody]='{1}', [MyDate1]=#{2}# ";
            strSQL += "WHERE ID={3}";
            string strBody = Body.Replace("'", "''");
            strSQL = string.Format(strSQL, strTitle, strBody, DateTime.Now, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void Insert(string Img, string strTitle, string Body)
        {
            string strSQL = "INSERT INTO tblNews([MyImg],[MyTitle],[MyBody],[MyDate1])";
            strSQL += "VALUES(";
            strSQL += "'{0}','{1}','{2}',#{3}#)";
            string strBody = Body.Replace("'", "''");
            strSQL = string.Format(strSQL, Img, strTitle, strBody, DateTime.Now);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}