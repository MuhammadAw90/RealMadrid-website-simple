using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RealMadrid
{
    public class CartClass
    {
        public static DataTable GetAll()
        {
            string strSQL = "SELECT * FROM tblCart ORDER BY [ID] ASC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
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