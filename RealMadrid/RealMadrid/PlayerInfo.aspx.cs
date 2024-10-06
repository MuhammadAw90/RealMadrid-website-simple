using System;
using System.Data;

namespace RealMadrid
{
    public partial class PlayerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strID = Request.QueryString["PlayerID"].ToString();
                FillGrid(strID);
            }
        }

        private void FillGrid(string strID)
        {
            try
            {
                DataTable dt = PlayersClass.PlayerByID(strID);
                if (dt.Rows.Count > 0)
                {
                    string strTable = "<h3><table>";
                    strTable += "<tr><td>Name :</td><td>" + dt.Rows[0]["MyName"].ToString() + "</td></tr>";
                    strTable += "<tr><td>Number :</td><td>" + dt.Rows[0]["MyNumber"].ToString() + "</td></tr>";
                    strTable += "<tr><td>Position :</td><td>" + dt.Rows[0]["MyPosition"].ToString() + "</td></tr>";
                    strTable += "<tr><td>DateOfBirth :</td><td>" + dt.Rows[0]["MyDateOfBirth"].ToString() + "</td></tr>";
                    strTable += "<tr><td>Country :</td><td>" + dt.Rows[0]["MyCountry"].ToString() + "</td></tr>";
                    strTable += "<tr><td>Info :</td><td>" + dt.Rows[0]["MyInfo"].ToString() + "</td></tr>";
                    strTable += "<tr><td>Image :</td></tr>";
                    strTable += "</table></h3>";
                    LabelInfo.Text = strTable;
                    string strTableImage = "";
                    DataTable dt1 = PlayersClass.GetAllPlayerImages(strID);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        strTableImage += "<img src=" + dt1.Rows[0]["MyFileName"].ToString() + " width=\"600\" height=\"700\">";
                    }
                    Image.Text = strTableImage;

                }
                else LabelMsg.Text = "There Is No Result";
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}