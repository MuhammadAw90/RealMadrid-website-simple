using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RealMadrid;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for Player
    /// </summary>
    public class PlayersClass
    {
        public static DataTable GetAllPlayers()
        {
            string strSQL = "SELECT * FROM tblPlayers";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetAllPlayerImages(string strID)
        {
            string strSQL = "SELECT * FROM [tblPlayersImages] WHERE [MyPlayerID]=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetAllPlayerImagesByName(string strName)
        {
            string strSQL = "SELECT * FROM [tblPlayersImages] WHERE [MyType]='" + strName + "'";
            strSQL += " ORDER BY [MyUploadDate] DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static bool IsPlayerExist(string strName, string strID)
        {
            string strSQL = "SELECT * FROM [tblPlayers] WHERE MyName = '{0}' AND [MyPlayerID] <> {1}";
            strSQL = string.Format(strSQL, strName, strID);
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            if (dt.Rows.Count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable PlayerByID(string strID)
        {
            string strSQL = "SELECT * FROM tblPlayers WHERE MyPlayerID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable PlayerByNumber(string strNumber)
        {
            string strSQL = "SELECT * FROM tblPlayers WHERE [MyNumber]=" + strNumber;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable PlayerByName(string strName)
        {
            string strSQL = "SELECT * FROM [tblPlayers] WHERE [MyName]='" + strName + "'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static string UpdateImageName(string strID, string strImage)
        {
            try
            {
                string strSQL = "UPDATE tblPlayersImages Set [Myimage]='{0}' WHERE MyID=" + strID;
                strSQL = string.Format(strSQL, strImage);
                Dbase.ChangeTable(strSQL, "db.accdb");
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static void DeleteImageByID(string strID)
        {
            string strSQL = "DELETE * FROM [tblPlayersImages] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void DeletePlayer(string strID)
        {
            string strSQL = "DELETE * FROM tblPlayers WHERE PlayerMyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void UpdatePlayer(string Name, string Number, string Position, string DateOfBirth, string Country, string Info, string strID)
        {
            string strSQL = "UPDATE [tblPlayers] SET ";
            strSQL += "[MyName]='{0}', [MyNumber]={1}, [MyPosition]='{2}' , [MyDateOfBirth]=#{3}#,";
            strSQL += "[MyCountry]='{4}' , [MyInfo]='{5}'";
            strSQL += " WHERE [MyPlayerID]={6}";
            strSQL = string.Format(strSQL, Name, Number, Position, DateOfBirth, Country, Info, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertPlayer(string Name, string Number, string Position, string DateOfBirth, string Country, string Info)
        {
            string strSQL = "INSERT INTO [tblPlayers] ([MyName],[MyNumber], [MyPosition], [MyDateOfBirth], [MyCountry], [MyInfo]) ";
            strSQL += "VALUES (";
            strSQL += "'{0}', {1}, '{2}',#{3}#,'{4}','{5}'";
            strSQL += ")";
            strSQL = string.Format(strSQL, Name, Number, Position, DateOfBirth, Country, Info);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}