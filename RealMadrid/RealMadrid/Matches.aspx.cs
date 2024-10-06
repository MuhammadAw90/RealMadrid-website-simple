using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Matches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                MatchesWS ws = new MatchesWS();
                GridView1.DataSource = ws.GetClubs();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SHOW"))
            {
                MatchesWS WS2 = new MatchesWS();
                string str = e.CommandArgument.ToString();
                GridView2.DataSource = WS2.GetGames(str);
                GridView2.DataBind();
            }
        }
    }
}
