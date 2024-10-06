using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RealMadrid;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for Users
    /// </summary>
    public class UsersClass
    {
        public static DataTable GetAllUsers()
        {
            string strSQL = "SELECT * FROM [tblUsers]";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable GetAllAdmins()
        {
            string strSQL = "SELECT * FROM [tblUsers] WHERE [MyAdmin]='Yes'";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable UserByID(string strID)
        {
            string strSQL = "SELECT * FROM tblUsers WHERE MyID=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static DataTable UserByUserName(string UserName)
        {
            string strSQL = "SELECT * FROM tblUsers WHERE Myusername=" + UserName;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static bool IfUserExist(string username)
        {
            string strSQL = "SELECT * FROM tblUsers WHERE Myusername='{0}'";
            strSQL = string.Format(strSQL, username);
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            if (dt.Rows.Count > 0)
                return true;
            else return false;
        }

        public static DataTable ReturnUser(string username, string pw)
        {
            string strSQL = "SELECT * FROM tblUsers WHERE Myusername='{0}' AND Mypw='{1}'";
            strSQL = string.Format(strSQL, username, pw);
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            return dt;
        }

        public static void UpdateUser(string strID, string FName, string LName, string DateOfBirth, string EMail, string Gender, string UserName, string Password, string Admin)
        {
            string strSQL = "UPDATE tblUsers SET ";
            strSQL += "MyFname='{0}', MyLname='{1}', MyDateOfBirth=#{2}#,";
            strSQL += "MyEmail='{3}',MyGender='{4}',Myusername='{5}', Mypw='{6}', MyAdmin='{7}' ";
            strSQL += "WHERE MyID={8}";
            strSQL = string.Format(strSQL, FName, LName, DateOfBirth, EMail, Gender, UserName, Password, Admin, strID);
            Dbase.ChangeTable(strSQL, "db.accdb");

        }

        public static void InsertUser(string FName, string LName, string DateOfBirth, string EMail, string Gender, string UserName, string Password, string Admin)
        {
            string strSQL = "INSERT INTO tblUsers ([MyFname], [MyLname], [MyDateOfBirth], [MyEmail], [MyGender], [Myusername], [Mypw], [MyAdmin]) ";
            strSQL += "VALUES (";
            strSQL += "'{0}', '{1}', #{2}#,'{3}','{4}','{5}','{6}','{7}' ";
            strSQL += ")";
            strSQL = string.Format(strSQL, FName, LName, DateOfBirth, EMail, Gender, UserName, Password, Admin);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void InsertUser1(string FName, string LName, string DateOfBirth, string EMail, string Gender, string UserName, string Password, string privilege)
        {
            string strSQL = "INSERT INTO tblUsers ([MyFname], [MyLname], [MyDateOfBirth], [MyEmail], [MyGender], [Myusername], [Mypw], [MyAdmin]) ";
            strSQL += "VALUES (";
            strSQL += "'{0}', '{1}', #{2}#,'{3}','{4}','{5}','{6}','{7}' ";
            strSQL += ")";
            strSQL = string.Format(strSQL, FName, LName, DateOfBirth, EMail, Gender, UserName, Password, privilege);
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

        public static void DeleteUser(string strID)
        {
            string strSQL = "DELETE * FROM tblUsers WHERE MyID=" + strID;
            Dbase.ChangeTable(strSQL, "db.accdb");
        }

    }
}