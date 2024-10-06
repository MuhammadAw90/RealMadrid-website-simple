using System.Data;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for CupsClass
    /// </summary>
    public class CupsClass
    {
        public static DataTable GetALL()
        {
            string strSQL = "SELECT * FROM tblCups";
            return Dbase.SelectFromTable(strSQL, "db.accdb");
        }

        public static DataTable GetByID(string strID)
        {
            string strSQL = "SELECT * FROM tblCups WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetByName(string strName)
        {
            string strSQL = "SELECT * FROM tblCups WHERE MyName='" + strName + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void Delete(string strID)
        {
            string strSQL = "Delete * From tblCups WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void DeleteImage(string strID)
        {
            string strSQL = "Delete [MyImg] From [tblCups] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateImage(string strID, string Img)
        {
            string strSQL = "UPDATE [tblCups] SET [MyImg]='{0}' WHERE [MyID]={1}";
            strSQL = string.Format(strSQL, Img, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateCups(string strName, string strNumber, string strID)
        {
            string strSQL = "UPDATE tblCups SET ";
            strSQL += "[MyName]='{0}', [MyNumber]={1} ";
            strSQL += "WHERE MyID={2}";
            strSQL = string.Format(strSQL, strName, strNumber, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void Insert(string strName, string strNumber)
        {
            string strSQL = "INSERT INTO tblCups([MyName],[MyNumber])";
            strSQL += "VALUES(";
            strSQL += "'{0}',{1})";
            strSQL = string.Format(strSQL, strName, strNumber);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}