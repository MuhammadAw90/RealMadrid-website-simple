using System;
using System.Data;

namespace RealMadrid
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillNews();
        }

        private void FillNews()
        {
            DataTable dt = NewsClass.GetAll();
            string strTable = "<table border=2>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strTable += "<tr><td>";
                strTable += "<img src=" + dt.Rows[i]["MyImg"].ToString() + " height=300 width=300 />";
                strTable += "</td><td>";
                string strID = dt.Rows[i]["MyID"].ToString();
                strTable += "<a href=LNew.aspx?ID=" + strID + " ><h3>" + dt.Rows[i]["MyTitle"].ToString() + "</h3></a>";
                strTable += "</td></tr>";
            }
            strTable += "</table>";
            LabelNews.Text = strTable;
        }
    }
}