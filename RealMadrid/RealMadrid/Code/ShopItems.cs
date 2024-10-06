using System.Data;
using System;
using System.Xml.Linq;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for ShopItems
    /// </summary>
    public class ShopItems
    {
        public static DataTable GetAll()
        {
            string strSQL = "SELECT * FROM tblShop ORDER BY [ItemID] ASC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetItem(string strID)
        {
            string strSQL = "SELECT * FROM tblShop WHERE ItemID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void DeleteNew(string strID)
        {
            string strSQL = "DELETE * FROM [tblShop] WHERE ItemID=" + strID;
            Dbase.SelectFromTable(strSQL, "db.accdb");
        }

        public static void UpdateImage(string strID, string Img)
        {
            string strSQL = "UPDATE [tblShop] SET [MyImg]='{0}' WHERE [ItemID]={1}";
            strSQL = string.Format(strSQL, Img, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdateNew(string strID, string strTitle, string Body)
        {
            string strSQL = "UPDATE tblShop SET ";
            strSQL += "[MyTitle]='{0}', [MyBody]='{1}', [MyDate1]=#{2}# ";
            strSQL += "WHERE ID={3}";
            string strBody = Body.Replace("'", "''");
            strSQL = string.Format(strSQL, strTitle, strBody, DateTime.Now, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void Insert(string name, string quantity, string price)
        {
            string strSQL = "INSERT INTO tblCart([ItemName],[Quantity],[Price])";
            strSQL += "VALUES(";
            strSQL += "'{0}','{1}','{2}')";
            strSQL = string.Format(strSQL, name, quantity, price);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}