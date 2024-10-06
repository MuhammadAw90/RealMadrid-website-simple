using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class LNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strID = Request.QueryString["ID"].ToString();
            FillNew(strID);
        }

        private void FillNew(string strID)
        {
            DataTable dt = NewsClass.GetNewByID(strID);
            string strTable = "<table>";
            strTable += "<tr><td><h1>";
            strTable += dt.Rows[0]["MyTitle"].ToString();
            strTable += "</h1></td></tr><tr><td>";
            strTable += "<img src=" + dt.Rows[0]["MyImg"].ToString() + " height=500 width=500 />";
            strTable += "</td></tr><tr><td><b>";
            strTable += dt.Rows[0]["MyBody"].ToString();
            strTable += "</b></td></tr>";
            strTable += "</table>";
            LabelInfo.Text = strTable;
        }
    }
}
