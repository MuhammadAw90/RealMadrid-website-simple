using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RealMadrid;
using System.Runtime.InteropServices.ComTypes;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for Files
    /// </summary>
    public class FilesClass
    {
        public static DataTable GetAllImages()
        {
            string strSQL = "SELECT * FROM [tblFiles] ORDER BY [MyUploadDate] DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;

        }
        public static DataTable SelectImage(string strID)
        {
            string strSQL = "SELECT * FROM [tblFiles] WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;

        }
        public static void DeleteFileByID(string strID)
        {
            string strSQL = "DELETE * FROM [tblFiles] WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertImage(string strFileName, int strLength, string strDescription)
        {
            string strSQL = "INSERT INTO [tblFiles]([MyFileName],[MyFilesize],[MyDescription],[MyUploadDate])";
            strSQL += "VALUES ('{0}','{1}','{2}',#{3}#)";
            strSQL = string.Format(strSQL, strFileName, strLength, strDescription, DateTime.Now);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }
    }
}