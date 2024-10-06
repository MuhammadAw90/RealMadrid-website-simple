using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Players : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridView();
            }
        }

        private void NoRepeat(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i]["MyPlayerID"].ToString() == dt.Rows[i + 1]["MyPlayerID"].ToString())
                {
                    dt.Rows.RemoveAt(i);
                }
            }
        }

        private void FillGridView()
        {
            try
            {
                DataTable dt = PlayersClass.GetAllPlayers();
                GridViewPlayers.DataSource = dt;
                NoRepeat(dt);
                GridViewPlayers.DataBind();
            }
            catch (Exception e)
            {
                LabelMsg.Text = e.Message;
            }
        }

        protected void GridViewPlayers_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewPlayers.SelectedIndex = e.NewSelectedIndex;
        }

        protected void GridViewPlayers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("SeeAll"))
                {
                    Response.Redirect("PlayerInfo.aspx?PlayerID=" + e.CommandArgument.ToString());
                }
            }

            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}