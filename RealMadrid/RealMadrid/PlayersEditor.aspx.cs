using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class PlayersEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("login.aspx");
            if (!IsPostBack)
            {
                FillGrid();
            }
        }
        private void FillGrid()
        {
            try
            {
                DataTable dt = PlayersClass.GetAllPlayers();
                GridViewPlayers.DataSource = dt;
                GridViewPlayers.DataBind();

            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }


        protected void GridViewPlayers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
        protected void GridViewPlayers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label strID = (Label)GridViewPlayers.Rows[e.RowIndex].FindControl("LabelID");
                PlayersClass.DeletePlayer(strID.Text);
                FillGrid();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewPlayers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewPlayers.EditIndex = -1;
            FillGrid();
        }

        protected void GridViewPlayers_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewPlayers.SelectedIndex = e.NewSelectedIndex;
        }

        protected void GridViewPlayers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label strID = (Label)GridViewPlayers.Rows[e.NewEditIndex].FindControl("LabelID");
            Response.Redirect("UpdatePlayer.aspx?MyPlayerID=" + strID.Text);
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePlayer.aspx?MyPlayerID=0");
        }
    }
}