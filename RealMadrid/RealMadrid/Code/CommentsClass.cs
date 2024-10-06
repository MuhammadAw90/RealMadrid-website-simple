using System.Data;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for CommentsClass
    /// </summary>
    public class CommentsClass
    {
        public static DataTable GetALL()
        {
            string strSQL = "SELECT * FROM [tblComments]";
            return Dbase.SelectFromTable(strSQL, "db.accdb");
        }

        public static DataTable GetByID(string strID)
        {
            string strSQL = "SELECT * FROM [tblComments] WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetByTitle(string strTitle)
        {
            string strSQL = "SELECT * FROM [tblComments] WHERE MyTitle='" + strTitle + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void Delete(string strID)
        {
            string strSQL = "Delete * From [tblComments] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }


        public static void UpdateComment(string strName, string strCity, string strTitle, string strData, string strID)
        {
            string strSQL = "UPDATE [tblComments] SET ";
            strSQL += "[MyName]='{0}', [MyCity]='{1}', [MyTitle]='{2}', [MyData]='{3}' ";
            strSQL += "WHERE MyID={4}";
            strSQL = string.Format(strSQL, strName, strCity, strTitle, strData, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void Insert(string strName, string strCity, string strTitle, string strData)
        {
            string strSQL = "INSERT INTO [tblComments]([MyName],[MyCity],[MyTitle],[MyData])";
            strSQL += "VALUES(";
            strSQL += "'{0}','{1}','{2}','{3}')";
            strSQL = string.Format(strSQL, strName, strCity, strTitle, strData);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}