using System.Data;
using System.Web.Services;

namespace RealMadrid
{
    /// <summary>
    /// Summary description for MatchesWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MatchesWS : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable GetClubs()
        {
            string strSQL = "SELECT * FROM [tblClubs]";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            dt.TableName = "Clubs";
            return dt;
        }

        [WebMethod]
        public DataTable GetGames(string strID)
        {
            string strSQL = "SELECT * FROM [tblMatches] WHERE [MyClubID]=" + strID;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            dt.TableName = "Clubs";
            return dt;
        }
    }
}