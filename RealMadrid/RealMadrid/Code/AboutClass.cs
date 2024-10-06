using System.Data;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for AboutClass
    /// </summary>
    public class AboutClass
    {
        public static DataTable About()
        {
            string strSQL = "SELECT * FROM [About]";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable AboutByTEXT(string Data)
        {
            string strSQL = "SELECT * FROM [About] WHERE [Data]='" + Data + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;

        }

        public static void UpdateAbout(string Data)
        {
            string strSQL = "UPDATE [About] SET [Data]='{0}' WHERE [ID]={1}";
            DataTable dt = About();
            strSQL = string.Format(strSQL, Data, dt.Rows[0]["ID"].ToString());
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}