using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealMadrid;

namespace RealMadrid
{
    public class UsefulLinksClass
    {
        public static DataTable GetALL()
        {
            string strSQL = "SELECT * FROM tblUsefulLinks";
            return Dbase.SelectFromTable(strSQL, "db.accdb");
        }

        public static DataTable GetByID(string strID)
        {
            string strSQL = "SELECT * FROM tblUsefulLinks WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetByTitle(string strTitle)
        {
            string strSQL = "SELECT * FROM tblUsefulLinks WHERE MyTitle='" + strTitle + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void Delete(string strID)
        {
            string strSQL = "Delete * From tblUsefulLinks WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void DeleteImage(string strID)
        {
            string strSQL = "Delete * From [tblFiles] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateImg(string strTitle, string Img)
        {
            string strSQL = "UPDATE tblUsefulLinks SET [MyImg]='{0}' ";
            strSQL += " WHERE [MyTitle]='{1}'";
            strSQL = string.Format(strSQL, Img, strTitle);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateUL(string strID, string strTitle, string strURL)
        {
            string strSQL = "UPDATE tblUsefulLinks SET ";
            strSQL += "[MyTitle]='{0}', [MyURL]='{1}', [MyDate]=#{2}# ";
            strSQL += "WHERE MyID={3}";
            strSQL = string.Format(strSQL, strTitle, strURL, DateTime.Now, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void Insert(string strTitle, string strURL)
        {
            string strSQL = "INSERT INTO tblUsefulLinks([MyTitle],[MyURL],[MyDate])";
            strSQL += "VALUES(";
            strSQL += "'{0}','{1}',#{2}#)";
            strSQL = string.Format(strSQL, strTitle, strURL, DateTime.Now);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}