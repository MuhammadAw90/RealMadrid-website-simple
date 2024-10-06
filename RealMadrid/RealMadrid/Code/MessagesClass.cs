using System;
using System.Data;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for MessagesClass
    /// </summary>
    public class MessagesClass
    {
        public static DataTable GetAllOutbox(string strID)
        {
            string strSQL = "SELECT tblOutbox.MyID , tblUsers.MyFname, tblUsers.MyLname, tblOutbox.MyTitle, tblOutbox.MyBody, tblOutbox.MyDate1 FROM tblUsers INNER JOIN tblOutbox ON tblUsers.MyID = tblOutbox.MySenderID WHERE tblOutbox.MyRecieverID=" + strID + " ORDER BY tblOutbox.MyDate1 DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetAllInbox(string strID)
        {
            string strSQL = "SELECT tblInbox.MyID, tblUsers.MyFname, tblUsers.MyLname, tblInbox.MyTitle, tblInbox.MyBody, tblInbox.MyDate1 FROM tblUsers INNER JOIN tblInbox ON tblUsers.MyID = tblInbox.MyRecieverID WHERE tblInbox.MySenderID=" + strID + " ORDER BY tblInbox.MyDate1 DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetInbox()
        {
            string strSQL = "SELECT * FROM tblInbox";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetByUserID(string UserID)
        {
            string strSQL = "SELECT * FROM tblMessages WHERE MyUserID=" + UserID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void DeleteInbox(string strID)
        {
            string strSQL = "Delete * From [tblInbox] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void DeleteOutBox(string strID)
        {
            string strSQL = "Delete * From [tblOutbox] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertInbox(string SenderID, string RecieverID, string Title, string Body)
        {
            string strSQL = "INSERT INTO [tblInbox]([MySenderID],[MyRecieverID],[MyTitle],[MyBody],[MyDate1])";
            strSQL += "VALUES(";
            strSQL += "{0},{1},'{2}','{3}',#{4}#)";
            string strBody = Body.Replace("'", "''");
            strSQL = string.Format(strSQL, SenderID, RecieverID, Title, strBody, DateTime.Now);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertOutbox(string SenderID, string RecieverID, string Title, string Body)
        {
            string strSQL = "INSERT INTO [tblOutbox]([MySenderID],[MyRecieverID],[MyTitle],[MyBody],[MyDate1])";
            strSQL += " VALUES ({0},{1},'{2}','{3}',#{4}#)";
            string strBody = Body.Replace("'", "''");
            strSQL = string.Format(strSQL, SenderID, RecieverID, Title, strBody, DateTime.Now);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}