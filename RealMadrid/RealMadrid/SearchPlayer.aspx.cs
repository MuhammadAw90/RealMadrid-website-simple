using System;
using System.Data;

namespace RealMadrid
{
    public partial class SearchPlayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGridDropDownListNumber();
                fillGridDropDownListName();
            }
        }

        private void fillGridDropDownListNumber()
        {
            DataTable dt = PlayersClass.GetAllPlayers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownListNumber.Items.Add(dt.Rows[i]["MyNumber"].ToString());
            }
        }

        private void fillGridDropDownListName()
        {
            DataTable dt = PlayersClass.GetAllPlayers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownListName.Items.Add(dt.Rows[i]["MyName"].ToString());
            }
        }

        protected void SearchByNumber()
        {
            string strNumber;
            strNumber = DropDownListNumber.SelectedValue.ToString();
            DataTable dt = PlayersClass.PlayerByNumber(strNumber);
            if (dt.Rows.Count == 1)
            {
                string strTable = "<h3><table>";
                strTable += "<tr><td>";
                strTable += "Name :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyName"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Number :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyNumber"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Position :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyPosition"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "DateOfBirth :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyDateOfBirth"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Country :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyCountry"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Information:" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyInfo"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Images :" + "</td><td></td>";
                string strID = dt.Rows[0]["MyPlayerID"].ToString();
                DataTable dt1 = PlayersClass.GetAllPlayerImages(strID);
                for (int k = 0; k < dt1.Rows.Count; k++)
                {

                    strTable += "<tr><td></td><td>";
                    strTable += "<img src='" + dt1.Rows[k]["MyFileName"].ToString() + "' height=200 width=200 />";
                    strTable += "</td></tr>";
                }
                strTable += "</tr>";
                strTable += "</table><h3>";
                LabelData.Text = strTable;
            }
            else
            {
                LabelMsg.Text = "There Is No Result";
                LabelData.Text = "";
            }
        }

        protected void SearchByName()
        {
            string strName;
            strName = DropDownListName.SelectedValue.ToString();
            DataTable dt = PlayersClass.PlayerByName(strName);
            if (dt.Rows.Count == 1)
            {
                string strTable = "<h3><table>";
                strTable += "<tr><td>";
                strTable += "Name :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyName"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Number :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyNumber"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Position :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyPosition"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "DateOfBirth :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyDateOfBirth"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Country :" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyCountry"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Information:" + "</td>";
                strTable += "<td>";
                strTable += dt.Rows[0]["MyInfo"].ToString();
                strTable += "</td></tr>";
                strTable += "<tr><td>";
                strTable += "Images :" + "</td><td></td>";
                string strID = dt.Rows[0]["MyPlayerID"].ToString();
                DataTable dt1 = PlayersClass.GetAllPlayerImages(strID);
                for (int k = 0; k < dt1.Rows.Count; k++)
                {

                    strTable += "<tr><td></td><td>";
                    strTable += "<img src='" + dt1.Rows[k]["MyFileName"].ToString() + "' height=200 width=200 />";
                    strTable += "</td></tr>";
                }

                strTable += "</tr>";
                strTable += "</table><h3>";
                LabelData.Text = strTable;
            }
            else
            {
                LabelMsg.Text = "There Is No Result";
                LabelData.Text = "";
            }
        }

        protected void DropDownListNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchByNumber();
        }
        protected void DropDownListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchByName();
        }
    }
}